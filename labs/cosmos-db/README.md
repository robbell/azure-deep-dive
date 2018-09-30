# Cosmos DB lab

## Provision a Cosmos DB database using ARM

### Log in to the Azure CLI

`az login`

### Set the active subsciption

Get a list of available subscriptions:

`az acount list`

Set the active subscription:

`az account set -s [SubscriptionId]`

### Create the resource group

`az group create -l northeurope -n [MyResourceGroupName] --tags bootcamp-session=azure-deep-dive`

### Create the deployment using the Cosmos DB template

`az group deployment create -g [MyResourceGroupName] --template-file .\cosmos-db-provisioning.json`

When deployment begins you will be prompted for a database account name. This must be lower case and globally unique.

After deployment is complete, keep hold of the `outputs` section.

## Running the project

### Edit the solution

Replace the `endpointUri` and `primaryKey` in `Program.cs` with those taken from the `outputs` section of the deployment.

### Run the application

* Add some breakpoints and step through the execution of the application

* Try making changes to the object being written

* Log in to the Azure Portal and use the CosmosDB Data Explorer to see what's been persisted.

## Tear down

### Delete the resource group

`az group delete -n [MyResourceGroupName]`

## Bonus questions

* Tweak the query - which LINQ methods are available?
* What happens if you try to create a document with the same ID? How can we work ensure a document is either created or update?
* What do you need to do in order to write a different shaped object to Cosmos? What happens when you read back an incomplete or changed object?
