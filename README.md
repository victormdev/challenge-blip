# Projeto API C# e Fluxo do Blip

## Descrição

Este projeto é composto por uma API desenvolvida em C# e um fluxo de chatbot em formato JSON utilizando o Blip.

- A **API C#** é responsável por listar informações sobre os 5 (cinco) repositórios de linguagem C# mais antigos do GitHub fornecido (https://github.com/takenet), ordenados do mais antigo para o mais novo. Subi a aplicação no Azure (https://repository-fngqa2ecgkeuexfr.canadacentral-01.azurewebsites.net/api/repositories).
- O **fluxo Blip** em JSON define as interações e lógica do chatbot, utilizando os dados fornecidos pela API.

## Observações

- Sobre a requisição HTTP, eu tinha adicionado a url nas variáveis de configuração do bot. Mas, ao exportar o fluxo, essas informações são perdidas. Por isso deixei diretamente na url da requisição do bloco.
- Na parte de listar os repositórios, eu optei por montar o conteúdo dinâmico no script e adicionar depois no formato de carrossel.
- Em "Saber mais", o WhatsApp não renderiza quando é a partir de três opções no Quick Reply, mas como o teste vai ser feito no Blip Chat, eu deixei a lista com todas as opções.

No mais, é isso! Agradeço pela oportunidade e estou torcendo pra tudo dar certo! :)
