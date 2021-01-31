OCM Mirror
====

Abstract
----

Docker Environment to host an OCM Mirror. See https://github.com/openchargemap/ocm-system/issues/148.


Instructions
----

Make sure the docker subsysten is up and running.

```bash
docker-compose up -d
```

Then you should be able to perform OCM API Requests, e.g. using:

```bash
curl http://localhost:8080/api/v3/poi
```

Author
----

* Remus Lazar (remus at ev-freaks.com)