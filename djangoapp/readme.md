#  djangoapp + mysql 

### example 02

# requerimientos

- python3+
- django 

###  Create project
- `python3 -m pip install virtualenv`
- `python3 -m virtualenv venv`
- `source venv/bin/activate`
- `(venv) pip install django`
- `(venv) django-admin startproject djangoProject`
- `deactivate`
- `cd djangoProject`
- `python3 -m virtualenv venv`
- `source venv/bin/activate`
- `(venv) python manage.py startapp app`
- `(venv) pip install pymysql`
- `(venv) pip install python-dotenv`


### Docker working
 
- `docker-compose build`
- `docker-compose up`
- `docker-compose run app npm i ${library}`