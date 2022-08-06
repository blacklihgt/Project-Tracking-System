# PROJECT TRACKING SYSTEM

- Building a distributed system with heterogenous clients. System is to be implemented using Microsoft.NET technology. The system will be built using C# and use an SQL database. IDE to be used will be Microsoft Visual Studio.

## Table of contents

1.Introduction
2.Roles of different users
3.Building the business component
4.Building admin GUI
5.Using .NET remoting
6.Creating a web service and client website

### Introduction

Out of Bounds Limited is a London based company which specialises in the management of Software development projects. It has several teams of project managers and developers who are experts in various fields. The teams are spread geeographically in distant locations. The provisions been used by the team for the day to day activities.They are thus developing a Project Tracking Syste to help them with this.

- Some of the functions of the system will be:

  -The system will allow the a manager to register projects.
  -Projects are divided into tasks.
  -Rules regarding the order of the tasks can be set.
  -Different tasks can be assigned to different teams.
  -Team leaders will be able to register task progress.
  -Customer can view summary information about structure of the project.

- System will be accessed by three different type of users.
    -ADministrator
    -Team Leader(s)
    -Customers

### Roles of different users

#### Administator

- Setting up the project
- Dividing project into tasks
- Assign Tasks to teams
- Create new teams if necessary
- Update any changes to project
- Track overall project progress

#### Team Leader

- Break tasks to sub tasks
- Estimation completion dates for new tasks.
- Assign sub tasks to team members.
- Record progress on particular tasks.
- Record completed tasks

#### Customer

- View project structure
- Track overall project of the project.

### Building the business component

- Will be built using the N-tier architecture model. It will consist of data tier, presentation tier and business tier.

#### Business Tier

- Contains the core functionality of business rules, workflows, provides controlled access to data and also enables validation and processing data input.
- Will contain components in the form of different classes which are:
  *Business objects - Abstract representation from our business domain.
  *Data access objects - Will be used to communicate to database
  *Facade objects - Will be used to interact with GUI

### Building the admin GUI

### Introducing .NET remoting
