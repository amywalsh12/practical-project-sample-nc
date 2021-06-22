terraform {
    required_providers {
        azurerm = {
            source  = "hashicorp/azurerm"
            version = "~> 2.46.0"
        }    
    }    
}

provider "azurerm" {
    features {}
}
variable "services" {
  description = "List of web apps"
  type        = map
  default     = {
    frontend = {
      name="front-end-project"
    },
    serviceone = {
      name="letters-project"
    },
    servicetwo = {
      name="numbers-project"
    },
    servicethree = {
      name="merge-project"
    },
  }
}

resource "azurerm_resource_group" "rg" {
    name     = "practical-project"
    location = "uksouth"
}
resource "azurerm_app_service_plan" "app-service-plan" {
  name = "gwl-tf-appservice"
  resource_group_name = azurerm_resource_group.rg.name
  location = azurerm_resource_group.rg.location
  kind = "Linux"
  reserved = true
  sku {
    tier = "Free"
    size = "F1"
  }
}
resource "azurerm_app_service" "webapp" {
  
    for_each = var.services
    name = each.value.name
    resource_group_name = azurerm_resource_group.rg.name
    location = azurerm_resource_group.rg.location
    app_service_plan_id = azurerm_app_service_plan.app-service-plan.id
}