# mini-curso-sitec
Repositório referente ao minicurso ministrado no evento SITEC na UFPA, para a criação do jogo Flappy Bird usando Unity. 

Baseado no tutorial : [Valem](https://www.youtube.com/watch?v=uRWmEjxY334)



### Criar um novo Projeto Unity

Abra o aplicativo `Unity Hub` e crie um novo projeto

- Nome : "FlappyBird"
- Template: 2D
- Location: (qualquer pasta de sua preferencia)

Após esse processo, ira abrir um projeto vazio.

### Preparar as imagens

Dentro da pasta `arquivos_minicurso` copie o arquivo `FlappyBirdSprites.png` para a pastas `Assets > Sprites`.


Com o arquivo dentro do Unity, clicke uma vez com o botão esquerdo, note que ira aparecer as configurações desse arquivo no `Inspertor`, agora vamos alterar:

- Sprite Mode > Multiple 
- Filter Mode > Point (no filter)
- Compression > None

e clickar em `Sprite Editor`.

Nesta tela, vamos selecionar as figuras que queremos, clickando com o botão esquerdo e selecionando a area desejada, após isso, em uma pequena tela no canto inferior, digitaremos o nome da imagens selecioada. 

Vamos fazer esse processo 10 vezes, nas seguintes partes: 

- BackGround
- CanoUM
- CanoDois
- Chao
- textFlappyBird
- textGameOver
- Play
- BirdUm
- BirdDois
- BirdTres

*Os nomes nao podem conter caracteres especiais.

### Organizar as Imagens

Com as imagens separadas, vamos colocar elas no lugar.

#### BackGround

Pegue o `BackGround` e arraste para a `Hierarchy`. Certifique-se que,

- `Tranform > Position` está com os valores (x: 0 , y: 0, z: 0)
- `Tranform > Scale` está com os valores (x: 4 , y: 4, z: 1)

Vamos ajustar a `Camera` na aba `Game` na segunda opção na parte superior trocaremos a resulução para `9:16`

*Caso nao tenha, adicione clickando no icone `+` e configure para `Type > Aspect Radio` e `Width e Heigth: 9 16`.

Após isso, a resolução da camera estará do mesmo tamanho da imagem. 

#### Chao

Da mesmo forma feito anteriomente, pegue o `Chao` e arraste para a `Hierarchy`.
Recomendamos que,

- `Tranform > Scale` está com os valores (x: 4 , y: 4, z: 1)

*A `Position` e `Scale` podem ser ajustados de acordo com sua preferencia.

#### Bird

(...)