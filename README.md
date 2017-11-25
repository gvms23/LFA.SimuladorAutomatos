# LFA.SimuladorAutomatos


![alt text](https://media.licdn.com/mpr/mpr/AAEAAQAAAAAAAAmTAAAAJGE2OWEzYTFjLWMxNWMtNGU2ZS04ZjJiLTM1NmIxZDg2ODM1Yg.png)

![alt text](https://media.licdn.com/mpr/mpr/AAEAAQAAAAAAAApZAAAAJDYyZmFkNGVkLWIzZjUtNGI1Ny1iYTkzLTBkNTAzYjUwNTYzZg.png)

Software básico desenvolvido para trazer à prática dois de 5 exercícios dados em uma lista. A matéria em questão é Linguagens Formais e Autômatos, para analisarmos estruturas lógicas que seriam lidas por máquinas.

Será inserida uma determinada cadeia de caracteres de entrada no Textbox "txtEntrada" e tal cadeia será validada no GroupBox "Resultado" com base nos parâmetros lógicos, no caso do exercício 1 - W (entrada) pertence a uma cadeia de 0s e 1s, logo o utilizador não pode digitar 2 senão a máquina não entenderá e W (entrada) inicia-se em 0 e termina em 1.

O parâmetro lógico do exercício 2 é próximo do anterior, só que nesse os dois últimos caracteres digitados devem ser obrigatoriamente "00".

Os círculos brancos são os estados, cuja nomenclatura eu utilizei "Q[número_do_estado]", ou seja, q0, q1 e q2. Onde q0 é o estado inicial pois há uma seta colocada a sua esquerda e q2 é o estado final por nele haver um círculo duplo.

Foram colocadas funcionalidades adicionais como por exemplo o log de operações, uma forma de acompanhar passo a passo dos estados:
![alt text](https://media.licdn.com/mpr/mpr/AAEAAQAAAAAAAArcAAAAJDcyNWM3N2VhLWNlZTctNDg5ZS1iNjU2LTdiZmE2NjkyZDU5Yw.png)


No TextBox txtEntrada foi colocado o seguinte código para que só aceite 0s, 1s e a tecla Backspace:

        private void txtEntrada_KeyPress(object sender, KeyPressEventArgs e)
        {
            var validKeys = new[] { Keys.Back, Keys.D0, Keys.D1 };

            e.Handled = !validKeys.Contains((Keys)e.KeyChar);
        }
Esse método foi colocado no evento Key_Press do TextBox.

Para abrir outro Formulário, foi colocado o seguinte código utilizando o conceito básico de Thread e expressão Lambda:

   public void abreFormExercicio2()
        {
            //abre o outro form
            //função para abrir outro form em um novo thread
            //expressão lambda "=>"
            var novoThread = new Thread(() =>
            {
                Application.Run(new frmExercicio2());
            });

            //inicia o novo thread
            novoThread.Start();

            //fecho esse form atual com o dispose e limpo
            //sua referência na memória
            this.Dispose();
        }
Vídeo com o funcionamento:

<div align="center">
  <a href="https://www.youtube.com/watch?v=-m_6-NcoNHc" target="_blank"><img src="https://img.youtube.com/vi/-m_6-NcoNHc/0.jpg" alt="Simulador de Autômatos - C# (Youtube)"></a>
</div>
