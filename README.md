# Configure and run the project

Clone this reposority. After that, do this:

```
docker compose build
docker compose up
```


Check if the Api is up and running: http://localhost:8080/random-number

Api metrics: http://localhost:8080/metrics

check if the target is up and running on Prometheus: http://localhost:9090/targets
![image](https://github.com/faulycoelho/article-api-prometheus-grafana/assets/37049426/49108a2c-f22f-4149-9325-70f99dd09498)


Go to Grafana and add a new datasource to Prometheus:
url: https://prometheus:9090

Add dashboards:
```sum by(code) (http_request_duration_seconds_bucket)```

![image](https://github.com/faulycoelho/article-api-prometheus-grafana/assets/37049426/fdec54ab-1d65-4c4b-9f66-e0660ae0343f)
