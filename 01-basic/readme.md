## Docker 

```$ docker run --name personal-nginx -d -p 9090:80 nginx```

- **-d** detach
- **-p** puerto externo:interno

### copy file/folders to container

```$  docker cp demo.html personal-nginx:/usr/share/nginx/html``` 

- **cp** file container:/path/

### Work volume
```$ docker run --name personal-nginx -d -v $(pwd):/usr/share/nginx/html:ro -p 9090:80 nginx```

- **-v** volume /local/path/:/container/path/


