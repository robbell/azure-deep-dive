# Service Bus lab

## Provision Service Bus using ARM

### Log in to the Azure CLI

`az login`

### Set the active subsciption

Get a list of available subscriptions:

`az acount list`

Set the active subscription:

`az account set -s [SubscriptionId]`

### Create the resource group

`az group create -l northeurope -n [MyResourceGroupName] --tags bootcamp-session=azure-deep-dive`

### Create the deployment using the Service Bus template

`az group deployment create -g [MyResourceGroupName] --template-file .\service-bus-provisioning.json`

When deployment begins you will be prompted for a Service Bus namespace name.

After deployment is complete, keep hold of the `outputs` section.

## Running the project

### Edit the solution

Replace the `connectionString` in both `Program.cs` files with the one taken from the `outputs` section of the deployment.

### Run the application

* Start by running `service-bus-publisher` application (right-click on the solution and select _Debug_ > _Start new instance_)

* Now start two separate instances of the `service-bus-subscriber` application:
    * In the first window enter `MyFirstSubscription` and press <kbd>Enter</kbd>
    * In the second window enter `MySecondSubscription` and press <kbd>Enter</kbd>

* In the publisher window type in a message and press <kbd>Enter</kbd>. Observe the messages received by the two subscribing applications

* Stop the subscribers and open _ServiceBusExplorer_. Use the connection string from earlier and take a look at how namespaces, topics, subscriptions and messages are structured.

## Tear down

### Delete the resource group

`az group delete -n [MyResourceGroupName]`

## Bonus questions

* What happens if multiple subscribers subscribe to the same subscription? How might this be useful?