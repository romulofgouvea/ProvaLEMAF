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

vá até o local da pasta do projeto baixado, selecione a pasta:

```bash
ProvaLEMAF -> backend -> backend -> backend.CSPROJ
```
e clique em **Abrir**

Após carregado e aberto, pressione **F5** para a execução do projeto, após será aberto uma pagina do seu navegador sinalizando que o projeto está em execução

Obs: Não FECHE, se não o servidor vai PARAR.


## Front-end

Aplicação fron-end foi construída em Vue.JS, para consumir os dados recebidos através da API criada.

### Execução
Navegue até a pasta onde baixou os arquivos e abra um terminal a partir da pasta: 

```bash
ProvaLEMAF -> frontend
```

e execulte o comando no terminal:

```bash
npm run serve
```

Após isso suas duas aplicações estão funcionando:

sendo API rodando no localhost com a porta **64154**, visto na URL:
```bash
http://localhost:64154
```
e a aplicação front-end com a porta **8080** na URL: 
```bash
http://localhost:8080
```

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