# .NET으로 간단한 Laftel 기반 MCP 서버 만들기

## 준비물

- .NET SDK 9.0 이상

1. 다음 명령어를 입력하여 템플릿을 설치합니다.
	```sh
	dotnet new install Microsoft.Extensions.AI.Templates
	```
1. 이후 `dotnet new mcp` 명령어로 MCP 서버를 생성할 수 있습니다.
	```sh
	dotnet new mcpserver -n LaftelMcpServer
	```
1. [Laftel.http](./Laftel.http) 파일을 이용해 API를 테스트하고 필요한 구조를 정의합니다.
