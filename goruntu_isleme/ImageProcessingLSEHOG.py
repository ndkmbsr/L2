from skimage.feature import hog
from pylab import * 
import cv2
import numpy as np
from numpy.linalg import pinv
from sklearn.metrics import confusion_matrix
from sklearn.model_selection import train_test_split
import warnings
warnings.filterwarnings('ignore')
ymat_testEstimate=np.zeros([100,1])
hog_feature_test=np.zeros([100,1152]);
hog_feature=np.zeros([400,1152]);
ymat=np.ones([400]);
ymat[0:400:2]=-1;
A=np.zeros([300,1153])
AccuracyRate_list=[];

''' train data'''
for i in range(400):
    image=cv2.imread("ml/TrainData/Train_"+str(i+1)+".png",0);
    image=np.float64(image);
    fd, hog_image = hog(image, orientations=8, pixels_per_cell=(4,4),cells_per_block=(2, 2), visualise=True)
    fd=np.reshape(fd,[1,1152])
    hog_feature[i][:]=fd[0][:] 
    
for k in range(10):
    '''using Train data'''
        indices=range(400)    
    ymat_train, ymat_test, indices_train, indices_test = train_test_split(ymat, indices, test_size=0.25, random_state=seed())
    ymat_train=ymat_train.reshape(300,1)
    hog_train_feature=hog_feature[indices_train]
    hog_train_feature=hog_train_feature.reshape(300,1152)

    A=np.hstack((hog_train_feature,np.ones([300,1])))    
    zmat=np.dot(np.dot(pinv(np.dot(np.transpose(A),A)),np.transpose(A)),ymat_train)
    zmat=zmat.reshape(1153,1)
      
    '''using Test data'''
    hog_feature_test=hog_feature[indices_test][:]     
    for i in range(100):      
        ymat_testEstimate[i]=np.sign(np.dot(np.transpose(zmat[0:1152]),np.transpose(hog_feature_test[i]))+zmat[1152][0])
           
    conf_matrix=confusion_matrix(ymat_test,ymat_testEstimate)    
    accuracy_rate=(sum(np.diag(conf_matrix)))/np.sum(conf_matrix)*100;  
    AccuracyRate_list.append(accuracy_rate)
average=np.mean(AccuracyRate_list)
print(average)
