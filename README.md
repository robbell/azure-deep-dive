# Azure Deep Dive

My Azure Deep Dive course material from the ASOS Emerging Talent Bootcamp.

## Prerequisites

* .NET Core 2.1 SDK - [Download](https://www.microsoft.com/net/download/dotnet-core/2.1)
* Azure CLI 2.0 - [Download](https://docs.microsoft.com/en-us/cli/azure/install-azure-cli?view=azure-cli-latest)
* Contributor access to an Azure subscription

## Course outline

### Part 1 - Azure resources

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
        * Messaging vs direct calls: https://blogs.mulesoft.com/dev/connectivity-dev/why-messaging-queues-suck/
    * Azure Resource Manager
        * https://resources.azure.com
* Labs
    * Cosmos DB
    * Service Bus

### Part 2 - Architecting for the cloud

* Intro
* Common cloud patterns and the problems they solve
    * General, repeatable solutions to commonly occurring problems
    * Queue-based load levelling
    * Competing consumers
    * Caching
        * Cache aside vs read-through cache vs write-through cache: http://www.ehcache.org/documentation/3.5/caching-patterns.html
    * Materialised views
    * Sharding
    * Microsoft's cloud patterns book: https://docs.microsoft.com/en-us/azure/architecture/patterns/
    * Azure developer's guide: https://azure.microsoft.com/en-gb/campaigns/developer-guide/?v=18.31
* Architecture breakout sessions
* Wrap up and questions
