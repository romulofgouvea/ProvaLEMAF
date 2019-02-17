Após fazer o download/clonar o código, execute-o desta maneira.

# Introdução
Desenvolver uma aplicação seguindo o layout apresentado no PDF dentro do arquivo e desenvolver uma API para o consumo de dados

## Aplicações utilizadas
- VSCode
- Microsoft Visual Studio 2017

## Back-end

WebAPI feito em **ASP.NET**, para o consumo de dados via **JSON**

### Execução
Abra o Visual Stúdio, clique em:

```bash
arquivo -> abrir -> Projeto/Solução
```

vá até o LOCAL DA PASTA do projeto clonado, selecione a PASTA:

```bash
ProvaLEMAF -> backend -> backend -> backend.CSPROJ
```
e clique em **Abrir**

Após carregado e aberto, pressione **F5** para a execução do projeto, após será aberto uma pagina do seu navegador sinalizando que o projeto está em execução

Obs: Não FECHE, se não o servidor vai PARAR.

A API está rodando no localhost com a porta **64154**, visto na URL:

```bash
http://localhost:64154
```

## Front-end

Aplicação fron-end foi construída em Vue.JS, para consumir os dados recebidos através da API criada.

### Execução
Navegue até a pasta onde baixou os arquivos e abra um terminal a partir da pasta: 

```bash
ProvaLEMAF -> frontend
```

e execulte o comando no terminal para que baixe os arquivos do node_modules necessários para a execução do  projeto:

```bash
npm install
```

Para executar o projeto execute o dcomando abaixo no terminal:

```bash
npm run serve
```

Após isso suas duas aplicações estão funcionando e a aplicação front-end com a porta **8080** na URL: 
```bash
http://localhost:8080
```

### Teste API
Caso queira testar a API sem que esteja com o front-end aberto, instale uma aplicação chamada **Postman** usada para testar requisições em API's, Selecione o método GET e Cole a URL para consultar as viagens:

```bash
http://localhost:64154/api/Trips
```
para consultar as cidades: 
```bash
http://localhost:64154/api/City
```
para consultar as viagens para a cidade de Id: 132:
```bash
http://localhost:64154/api/Trips?trip_city=132
```

### Teste API

Exemplos de entrada do Aplicativo:

Dubai, data atual, 1 guest, First Class, 1000

Chile, data atual, 1 guest, First Class, 1000

colombia, data atual, 2 guest, First Class, 1000