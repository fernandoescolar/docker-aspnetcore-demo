FROM microsoft/aspnet 

COPY . /app 
WORKDIR /app 
RUN [ "dnu", "restore" ] 

EXPOSE 5000 
ENTRYPOINT [ "dnx", "-p", "project.json", "web", "--server.urls", "http://0.0.0.0:5000" ]
