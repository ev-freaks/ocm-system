API_ROOT := ../../../API

all: clean build

.PNONY: all clean build

build:
	docker build -t ocm-mirror -f ./Dockerfile $(API_ROOT)

clean:
	docker image rm ocm-mirror
