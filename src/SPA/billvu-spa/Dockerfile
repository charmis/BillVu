FROM node:8.11.4

# set working directory
RUN mkdir /usr/src/app
WORKDIR /usr/src/app

# add `/usr/src/app/node_modules/.bin` to $PATH
ENV PATH /usr/src/app/node_modules/.bin:$PATH

# install and cache app dependencies
COPY package.json /usr/src/app/package.json
RUN npm install
RUN npm install -g @angular/cli@6.2.4

# add app
COPY . /usr/src/app

# start app
CMD ng serve --host 0.0.0.0 --port 4999

#docker build -t billvu.spa .
#docker run -d -p 4999:4999 billvu.spa
