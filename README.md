        Connection string per MySql senza docker (occorre installare MySQL e MySqlWorkbench)
        
        server="localhost; port=3306; database=Scadenze; uid=userid;pwd=pwd"
        
        Connection string per MySql con docker*/

        1)Aprire il terminale e impartire il comando <<docker container ls>> per prendere l'identificativo del contenitore.
        2)digitare il comando <<docker inspect id_contenitore | grep Gateway>> per ottenere l'indirizzo ip del contenitore. La connection string
          è simile alla seguente: <<server = "server=ip trovato; port=3306; database=Scadenze; uid=userid;pwd=pwd">>"
        
        se non hai impostato un utente in MySql userid=root, pwd la password di root
        Ho creato la migrations. Per apportare le modifiche al database usare
        il comando -> dotnet ef database update se non usi docker. Per docker
        utilizzare il file scadedenzario.sql ed eseguirlo in MySqlWorkbench
        per creare la base dati. 
        
        ti lascio il link con le istruzioni da eseguire per pubblicare
        l'applicazione in docker. Su macos il deploy è un problema
        quindi ho dockerizzato l'applicazione:

        docker:https://www.docker.com
        installazione in un container:https://learn.microsoft.com/en-us/aspnet/core/security/docker-compose-https?view=aspnetcore-7.0
        
        Nel file appsettings.json trovi le istruzioni su come configurare il server di posta, il
        ReCaptcha e l'autenticazione con i provider esterni.
        
        
        COSTANTI PER DOCKER COMPOSE CONTENUTE IN UN FILE DI NOME AD ESEMPIO myenv.dev
        
        MYSQL_ROOT_PASSWORD=password di MySql
        CERTIFICATE_PASSWORD=password certificato
        NOME_CERTIFICATO=nome certificato

        COMANDO DOCKER PER INCLUDERE IL FILE myenv.dev

        docker compose --env-file myenv.dev up

        COMANDI DOCKER

        docker compose build --compilazione
        docker compose up --esecuzione# Scadenzario
# Scadenzario
# Scadenzario
