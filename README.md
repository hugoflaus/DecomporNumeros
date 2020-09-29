<h1>Descrição do problema</h1>

<p>
Um cliente precisa de um sistema que seja capaz de decompor um número em todos os seus divisores, enumerando também aqueles que forem primos. Obs.: Não é permitido o uso de bibliotecas prontas, se houver, que façam a decomposição.</p> 
<p>Dado um número de entrada, o programa deve calcular todos os divisores que compõem o número.</p> 
<p>Dado um número de entrada, o programa deve calcular todos os divisores primos que compõem o número.</p> 

## 🚀Tecnologias Utilizadas
- dotnet core
- C#

## 💻Testar o projeto
 - Foi utilizado a ferramenta postman

## Url

- Get => http://localhost:5000/api/decompor/numero
 <br />Ex: http://localhost:5000/api/decompor/12

 ## 📨Retorno:
 ```json
 {
    "status": 200,
    "data": {
        "divisores": [
            1,
            2,
            3,
            4,
            6,
            12
        ],
        "divisoresPrimos": [
            1,
            2,
            3
        ]
    }
}
```



