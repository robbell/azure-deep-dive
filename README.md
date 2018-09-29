# Azure Deep Dive

My Azure Deep Dive course material from the ASOS Emerging Talent Bootcamp.

## Prerequisites

* .NET Core 2.1 SDK - [Download](https://www.microsoft.com/net/download/dotnet-core/2.1)
* Azure CLI 2.0 - [Download](https://docs.microsoft.com/en-us/cli/azure/install-azure-cli?view=azure-cli-latest)
* Contributor access to an Azure subscription

## Course outline

### Part 1 - Azure resource types

* Why use the cloud? Quick slides on each as this has already been covered
    * "Cloud computing is just using somebody else's computers" - question to group
    * "Information technology as a utility, not a burden" - use electricity example
    * Availability
        * Self healing - services shifted between instances seemlessly 
        * Geo-located
    * Scalability/flexibility
        * Scale up, scale out, move resources to regions where they're required
    * Security
        * Specialists in how to protect against common attacks
        * Use of specialised attack detection tools not available to on premise 
    * Management
        * Patching, disk changes, other hardware, downtime, server moves, everything tied to a specific piece of hardware
        * Share the story of the old GS2 image servers at ASOS
    * Intelligent services - less reinventing the wheel
        * Facial recognition, search
        * Specialised, cloud-only resources like Cosmos
* Why Azure? 
    * Vs. other cloud providers: https://azure.microsoft.com/en-us/overview/azure-vs-aws/
    * Familiarity for .NET engineers, languages and resource types, lift and shift => Iaas to Paas to Saas
    * Cost
    * Special resource types for:
        * Certain data scenarios
        * Reliable messaging
    * Customer examples?
    * Density
* Azure resources overview
    * Virtual machines
    * Progression to containers via Service Fabric
    * Data stores
        * Azure SQL
        * CosmosDB
    * Service Bus
    * AppInsights
    * Interesting other resources
* Individual resource demos
    * CosmosDB
    * Service Bus
        * Check Service Bus explorer is installed
    * AppInsights
    * Others - something in ACI?

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