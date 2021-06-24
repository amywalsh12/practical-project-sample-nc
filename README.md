# practical-project-sample-nc


 




QA Practical Project Deliverable 

















Project summary
This project is to create 4 services all interdependent of each other but that are also connected to produce a result. I created an application producing a student number consisting of six digits and one letter. I then created resources in terraform and deployed using GitHub Actions. 
Project management 
Project management ensures there is an appropriate plan for executing and delivering a product or service to a client. Before implementing the project, it was crucial to justify the projects needs to develop the scope, objectives and requirements. 
From the initial project planning, I decided on an agile approach rather than a traditional one. This allows for iterative approach. 
Project methodology 
In the project management of this project, I chose to implement an agile approach. Using an agile methodology, it allows me to develop the project in different phases with a iterative approach. This methodology was effective to allow changes within the project as it progresses. It also allows updates from feedback gotten. 
To improve effectiveness of the development of the application, I used an online scrum tool called Trello. This was used due to its comprehensive tool set for use cases, responsibilities and roles. 
By doing iterative and incremental sprints I learned what worked and what didn’t. feedback from the tutors also provided valuable insight and improved progress.

Project objectives
•	To create a DevOps practical project that makes use of software development with C#, Continuous Integration and Cloud Fundamentals. 
•	To build an asana board (or Kanban board) with the expansion of tasks that were needed to complete
•	To create a risk analysis to record any issues/risks when creating the project.
•	To create an application that is fully integrated using the feature branch model into the version control system which will be built through a CI server and deployed to a cloud based environment 
•	Changes should be made through WebHooks IN Azure Pipelines that recreates and redeploys the changed application
•	Project must follow service-orientated architecture
•	Project must be deployed using an azure cloud platform but can deploy using the app using any azure service 

ERD

My Approach
The approach I have used to build and deploy my application is as follows:
•	Create an application that contains 4 services that are run independently to each other but also work together.  
o	Service 1: the core service. This service uses HTML to allow it to interact with the application. It also communicates to the other services.
o	Service 2: my numbers service. This service generates an object (numbers). I chose for it to create an 8 digit randomised number. 
o	Service 3: my Letters service. This creates one letter.
o	Service 4: this brings both services together and creates a student number i.e 12345678M.
•	Use Terraform to create services in Azure
These steps included :
1.	Scope: I checked the resources needed for the project. Eg the app services 
2.	Author: I then created the configuration file 
3.	Initialize: I executed ‘terraform init’ in my command line 
4.	Plan: I executed ‘terraform plan’ to verify the creation process and scan the configuration file for any detectable faults 
5.	Apply: I executed terraform apply. This creates the resources needed in azureCreate a second table called Goals (either CRUD functionality or populated with generic goals if ran out of time)

I then deployed the web pages using GitHub Actions 
•	I deployed and created a pipeline using visual studio code and GitHub Actions


 

Image of WorkFlow in GitHub Actions
 
Image of build and deploy GitHub Action
Tools Used:
•	Kanban Board: Asana or an equivalent Kanban Board
•	Version Control: Git
•	CI Server: GitHub Actions
•	Cloud Platform: Azure
•	Infrastructure as Code: Terraform
Development of application (own code)
I created an application with running code to meet the requirements for  code and testing. Below are the images of the running application along with the GitHub repository.  
  
 
Tools
CI Server: GitHub Actions 
Github actions was used as a CI Server that allows for continuous integration and delivery (CI/CD).  GitHub Actions allows developers to take actions to trigger events and use them to build custom pipelines. Developers can also build, test and deploy code on any platform and run their workflows in containers on virtual machines. it makes it easy to automate your software workflows. Moreover, Github actions connect to your tools to automate every step in the deployment workflow. 
Terraform
Terraform allows you to control your infrastructure on a cloud server provider i.e Azure. 
It uses infrastructure as code and allows one to create a high level of descriptive programming language to describe and manage infrastructure. 
In this project I used Workflows and followed steps to allow for deployment using terraform. 
 
image of a resource that was made using terraform in Azure
Cloud Platform: Azure
The azure cloud platform is made up of more than 200 products and cloud services that allow us to bring new solutions to life. It allows one to build, run and manage multiple applications across multiple clouds, on prem and at the edge all while using tools and frameworks of your choice. 

 


Risk analysis 
Risk analysis and management is key to project management to ensure the least amount of unexpected liabilities. Successful risk analysis involved continuous risk identification, risk evaluation, risk mitigation and contingency measures and risk monitoring & control.

RISKS	LIKILIHOOD	SEVERITY	CONTROL MEASURE	REVISIT

Accidently deleting code	Low 	High 	Backing up all code. Using GitHub with regular pushes mitigate this risk	Low because of github and constant pushing to the repository once code works 
Gold plating (adding additional features that weren’t asked for)	medium	medium	Keeping to the Scope of Work/replanning scope at each iteration. Also providing the MVP before trying to add more features	Low 
Lack of knowledge	high	high	Keeping up with the workload. Reaching out to Dara for help	Low/Medium- the project has helped to apply the theory in a practical approach which has solidifies the learning
Technical issue: application isn’t stable i.e application crashes, has bugs etc	medium	high	Continuous testing and continuous integration	Low/medium-regular pushes to github makes it easier to have working code and being able to pull it back is very beneficial to having a working application
Time Management: running out of time 	medium	medium	Using agile methodologies and project management tools	Low- better time management and a longer time to get things done made time less of a risk
				
				

Analysis of risk analysis:
Risk management is difficult as we cannot predict the future with certainty although by evaluating the risks we can help avoid a crisis and improves the successful completion of projects. 
By adding control measures it allows for decreased risk such as the deletion of code. Backing the code up to GitHub as a control measure allowed me to go back to original code when I had an issue with code I had. I unfortunately had a bug I could not overcome with the API and as a result I went back to the CRUD development part of the code. Although this took me a step backwards, I needed to go backwards to go forward in this case and the control in the risk evaluation enabled this.
Time Management:
Managing a project schedule and timeline is one of the key factors in successfully completing and delivering a project. Several online collaboration software tools  were used including Microsoft Teams, OneDrive, and Trello to manage time efficiently. 
Trello 



