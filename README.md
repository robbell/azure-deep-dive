# Azure Deep Dive

My Azure Deep Dive course material from the ASOS Emerging Talent Bootcamp.

## Prerequisites

* .NET Core 2.1 SDK - [Download](https://www.microsoft.com/net/download/dotnet-core/2.1)
* Azure CLI 2.0 - [Download](https://docs.microsoft.com/en-us/cli/azure/install-azure-cli?view=azure-cli-latest)
* Contributor access to an Azure subscription

## Course outline

### Part 1 - Azure resource types

* Why use the cloud?
    * "Cloud computing is just using somebody else's computers"
    * "Information technology as a utility, not a burden"
    * Availability
    * Flexibility
    * Security
    * Maintenance
    * Other reasons:
        * Intelligent services
        * AI
        * Planet-scale databases
* Why Azure? 
    * Familiarity
    * Cost
    * Resources
    * Customer examples
    * Vs. other cloud providers: https://azure.microsoft.com/en-us/overview/azure-vs-aws/
* Azure resources overview
    * Compute options
    * Database options
    * Service Bus
* Labs
    * TBC

### Part 2 - Cloud patterns

* Intro
* Common cloud patterns and the problems they solve 
    * Messaging
        * Messaging vs direct calls - https://blogs.mulesoft.com/dev/connectivity-dev/why-messaging-queues-suck/
        * Push/pull, fat/thin messages
        * Pros cons of both approaches
        * Security
        * Eventual consistency, CAP theorem
        * Competing consumers with queues and subscriptions, use of topics
        * Priority queues
    * Load levelling
    * Throttling
    * Caching
        * Cache aside vs read through vs write through
    * Event sourcing? Might be a bit too deep
    * Sharding
        * Examples?
    * Materialised view
    * CDN
    * Circuit breaker
    * Retry
* Demos incorporating different patterns:
    * Queues/topics for load levelling
    * Throttling
    * Competing consumers
    * Circuit breaker
    * Caching 

## Running the labs

### Login

`az login`

### Set the active subsciption

Get a list of available subscriptions:

`az acount list`

Set the active subscription:

`az account set -s [SubscriptionId]`

### Create a resource group

`az group create -l northeurope -n [MyResourceGroupName] --tags bootcamp-session=azure-deep-dive`

### Create a deployment

`az group deployment create -g [MyResourceGroupName] --template-file .\my-provisioning-template.json`

### Delete a resource group

`az group delete -n [MyResourceGroupName]`