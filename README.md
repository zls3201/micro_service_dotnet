
1. Start Consul, access web http://localhost:8500/ui

```sh
consul agent -dev -ui -server -datacenter=dc1 -bootstrap-expect=1  -bind=127.0.0.1 -client=0.0.0.0  -node=n1 -data-dir=./data/ -config-dir=./conf
```

2. Start OcelotServer

3. configuration Ocelet, access http://localhost:8500/ui/dc1/kv/Oceolot_A/edit ,then edit Json "Route" field

```json
[    {
      "UpstreamPathTemplate": "/apiservice/{controller}",
      "UpstreamHttpMethod": [ "Get" ],
      "DownstreamPathTemplate": "/apiservice/{controller}",
      "DownstreamScheme": "http",
      "DownstreamHostAndPorts": [
        {
          "host": "localhost",
          "port": 5011
        },
        {
          "host": "localhost",
          "port": 5012
        }
      ],
      "LoadBalancerOptions": {
        "Type": "LeastConnection"
      }
    }]
```

4 Run ApiServiceA/run_one.bat , Run ApiServiceA/run_two.bat

5 access web  http://localhost:5000/apiservice/Values