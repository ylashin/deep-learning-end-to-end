# Deep Learning end to end

## Introduction

Well, it's a long story but to cut it short I want to have a .NET production-grade application (let's say MVP) that is mainly based on deep learning. Many tutorials on the internet are already there but they are either about the training step only or written in Python with little consideration on how to plug the cool toy into a commerical working application. Rest assured we will not be doing MNIST again but something a tiny bit more advanced. Guess what, dogs vs cats. To add some context here, we had recently got requirements for client projects that should be best implemented with the help of deep learning techniques. Sometimes you can use a ready made API like Microsoft Cognitive Services, sometimes you need to roll out your own custom solution and operationalise it.

Another goal of this tutorial is to start with barely nothing and then progress gradually into the final working model (deep learning network) that can be consumed from a .NET application.


## Pre-requisites
You will need to have an Azure account as we will need Azure GPU based VM, Kubernetes cluster, Azure SQL database and Azure App Service.

You should be familiar with Microsoft .NET & C# but hopefully the steps will be very easy to follow from any development background as .NET/C# are not the core topics here. 

We will need Visual Studio and you can use the free Community Edition. It will be needed to publish the final web application to Azure or maybe test it locally if you do not want to publish it. 

A DockerHub account is needed as well because we will deploy a new image to DockerHub.

## Overview

The main steps of this tutorial are:
1. [Setup Azure VM using Data Science template and a GPU enabled HW](1.SetupAzureVM.md)
1. [Progressively run Jupyter notebooks to come up with a trained model](2.RunJupyterNotebook.md)
1. [Create a docker image to serve trained model using TensorFlow Serving](3.CreateServingDockerImage.md)
1. [Create a Kubernetes cluster to host TensorFlow Serving](4.CreateKubernetesCluster.md)
1. [Consume trained model from a .NET application using gRPC protocol](5.ConsumeModelFromWebApp.md)

So let's dig deep with first step.

[Setup Azure VM using Data Science template and a GPU enabled HW](./1.SetupAzureVM.md)

![Deep Learning](images/Deep_learning.png)
