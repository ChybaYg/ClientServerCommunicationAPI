# ClientServerCommunicationAPI
This repository is used as a part for my bachelor thesis. I needed to somehow transfer used methods on tested server, but the server worked on outdated .NET framework, so i came up with this program. 


Usage
Client should be used as a process. Whenever you want to send some string to the Listener component you have to create a file in ClientAPIConnect\ClientAPIConnect\bin\Debug\WorkingDirectory. After it was done so, the ClientAPIConnect.exe has to be started as a process using name of the created file an argument for the process. Right now the Client and also Listener are set u to send and accept data on the Loopback interface on the port 11000. But could be set up otherwise.

Before the starting of the Client it is mandatory to start a Listener. The Listener is not very well designed, so it takes a lot of cpu to keep it alive.  

