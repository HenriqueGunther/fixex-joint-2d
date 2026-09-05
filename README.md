Trabalho da disciplina Tecnologias Emergentes (Games) - Avaliação Game Engine

Integrantes do grupo
Felipe Cenedese - 1139705, Henrique Gunther - 1135955, Marco Antônio - 1134328

Recurso escolhido: Fixed Joint 2D

O Fixed Joint 2D é um componente do Unity que conecta dois objetos com Rigidbody2D de forma rígida, travando a distância e o ângulo relativos entre eles no momento em que a conexão é criada. É como se existisse uma barra invisível prendendo um objeto ao outro.

O componente possui um campo chamado Break Force, que define a quantidade de força necessária para que essa conexão se rompa. Quando uma força de impacto maior que esse valor é aplicada, a junção quebra e os objetos se separam, passando a se comportar de forma independente.

O que o protótipo demonstra

Foram construídas duas estruturas de "ponte", cada uma feita de blocos conectados entre si por Fixed Joint 2D:

Ponte grande: composta por 3 blocos, com um valor de Break Force mais alto (mais resistente).
Ponte pequena: composta por menos blocos, com um valor de Break Force mais baixo (mais frágil).

O jogador pode disparar dois tipos de objeto para testar a resistência das pontes:

Tecla 1: spawna uma bola leve (Rigidbody2D com massa baixa). Ao cair sobre a ponte grande, não gera força suficiente para quebrá-la, mas rola e cai sobre a ponte pequena, quebrando-a.
Tecla 2: spawna uma bola pesada (Rigidbody2D com massa alta). Ao cair sobre a ponte grande, a força do impacto ultrapassa o Break Force configurado, quebrando a estrutura.