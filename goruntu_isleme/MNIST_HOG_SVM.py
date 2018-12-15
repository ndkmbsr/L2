from skimage.feature import hog
from sklearn import svm
import numpy as np

from sklearn.metrics import confusion_matrix
from datetime import datetime
import warnings
warnings.filterwarnings('ignore')

''''Main Function'''
start_time=datetime.now()
train_images=np.load('train_images.npy')
test_images=np.load('test_images.npy')
train_labels=np.load('train_labels.npy')
test_labels=np.load('test_labels.npy')
n=1152;

hog_feature_train=np.zeros([len(train_images),n]);
hog_feature_test=np.zeros([len(test_images),n]);


for i in range(len(train_images)):    
    hog_values = hog(train_images[i,:,:], orientations=8, pixels_per_cell=(4,4),cells_per_block=(2,2))
    hog_feature_train[i]=hog_values    

for i in range(len(test_images)):    
    hog_values = hog(test_images[i,:,:], orientations=8, pixels_per_cell=(4,4),cells_per_block=(2,2))    
    hog_feature_test[i]=hog_values



model = svm.SVC(decision_function_shape='ovo')
#model = svm.SVC()
model.fit(hog_feature_train,train_labels) 
label_estimate=model.predict(hog_feature_test) 

conf_matrix=confusion_matrix(test_labels,label_estimate)
accuracy_rate=(sum(np.diag(conf_matrix)))/np.sum(conf_matrix)*100;  
print("Accuracy Rate: " ,accuracy_rate)

'stop time'
stop_time=datetime.now()
elapsed_time=stop_time-start_time
print("Elapsed Time: " +str(elapsed_time))
