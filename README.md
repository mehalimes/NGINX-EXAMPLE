1 - First you need to install nginx on your computer. <br>
2 - Then you need to replace your nginx.conf file with this repository's nginx.conf file. <br>
3 - After that, write the ports on which the solutions work in the upstream section of nginx.conf file. <br>
4 - Finally access the same endpoints of these two solutions via the nginx server's endpoint. ( Like https://localhost:8080/api/First/getValue ) <br>
5 - And there you have a solution based load balancer.<br>
