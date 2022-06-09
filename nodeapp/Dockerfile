
ARG ms_port=3000

FROM node:16.3.0-alpine
WORKDIR /usr/src/app
COPY package*.json ./

# dev
RUN npm install

# prod
# RUN npm ci --only=production

COPY . .
EXPOSE $ms_port
CMD ["node", "./bin/www"]
