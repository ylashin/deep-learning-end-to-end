# Deploy TensorFlow Serving container in Azure

Once we have the container ready and published to docker repository, we can create a docker cluster in Azure managed using Kubernetes and have the container running in a *high availability* fashion. You can use any other cloud service but you need to use your own deployment procedure for Google or AWS for example but the concept will be still the same. We have a container with needed S/W plus data and we need to run it in a publicly accessible docker cluster.

First we will need to create a resource group to host this cluster. We will need to run the below in Azure CLI locally or the one provided in the portal.

```
az group create --name InceptionServing --location australiaeast
```

Next, we will need to cretae Kubernetes cluster, connect to it and verify it is up and running. This can take a bit of time so be patient. 


```
az acs create --orchestrator-type kubernetes --resource-group InceptionServing --name InceptionServingK8sCluster --generate-ssh-keys

az acs kubernetes get-credentials --resource-group=InceptionServing --name=InceptionServingK8sCluster

kubectl get nodes
```

The next step is to download Kubernetes configuration file and create a new service based on this file.


```
wget https://raw.githubusercontent.com/ylashin/deep-learning-end-to-end/master/Kubernetes/inception_k8s.yaml
kubectl create -f azure-vote.yml
```