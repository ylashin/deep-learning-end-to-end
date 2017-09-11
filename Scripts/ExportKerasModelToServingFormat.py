from __future__ import print_function
from keras import backend as K
from keras.models import load_model
from tensorflow.python.saved_model import builder as saved_model_builder
from tensorflow.python.saved_model import tag_constants, signature_constants
from tensorflow.python.saved_model.signature_def_utils_impl import build_signature_def, predict_signature_def
import shutil
import os
import numpy as np
import tensorflow as tf

K.set_learning_phase(0)
model = load_model("/dogs-vs-cats-inception.hdf5")
print("Model loaded")
print("Model input:")
print(model.input)
print("Model output:")
print(model.output)

export_path = '/export/dogs-vs-cats/1'
builder = saved_model_builder.SavedModelBuilder(export_path)
signature = predict_signature_def(inputs={"inputs": model.input}, outputs={"outputs": model.output})

with K.get_session() as sess:
	builder.add_meta_graph_and_variables(sess=sess,tags=[tag_constants.SERVING],signature_def_map={'predict': signature})
	builder.save()

	
print("Model exported to : /export/dogs-vs-cats/1")