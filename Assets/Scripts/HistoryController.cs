using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HistoryController : MonoBehaviour
{
    public Text textoHistoria;
    public Rigidbody player;
    private int espacos;
    private int historia;

    // Start is called before the first frame update
    void Start()
    {
        espacos = 0;
        textoHistoria.text = "Essa é a história de um Rei,\nUm rei que amava muito o seu povo...\nMas o que deveria ser algo bom, levou-lhe a sua ruina. "
        + "\n\n\nClique Espaço para continuar";
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            if(historia == 0)
            {
                espacos++;
                switch (espacos)
                {
                    case 1:
                        textoHistoria.text = "Está é uma das poucas coisas que ainda lembro...";
                        break;
                    case 2:
                        textoHistoria.text = "Espere... Que lembro? O que eu lembro?";
                        break;
                    case 3:
                        textoHistoria.text = "Quem eu sou?";
                        break;
                    case 4:
                        textoHistoria.text = "... E ainda, por que estou aqui?";
                        break;
                    case 5:
                        textoHistoria.text = "De qualquer forma...\nAcho que devo entrar nesta porta a direita aqui...";
                        break;
                    default:
                        textoHistoria.text = "";
                        espacos = 500;
                        break;
                }
            }
            else if (historia == 1)
            {
                if(espacos >= 500)
                    espacos = 0;
                espacos++;
                switch (espacos)
                {
                    case 1:
                        textoHistoria.text = "Sim...\nDe alguma forma reconheço este lugar...\nEssas roupas...";
                        break;
                    case 2:
                        textoHistoria.text = "Essas são as roupas do meu fiel conselheiro...";
                        break;
                    case 3:
                        textoHistoria.text += "Eu sempre quis agradecê-lo";
                        break;
                    case 4:
                        textoHistoria.text = "Mesmo após a morte de minha esposa,\nele sempre me ajudou a superar tudo.";
                        break;
                    case 5:
                        textoHistoria.text = "Sempre me ajudou a focar em meus objetivos\ne no trabalho como governante.";
                        break;
                    case 6:
                        textoHistoria.text = "Por mais que possa ter sido difícil por vezes,\nfoi isso que me manteve de pé";
                        break;
                    case 7:
                        textoHistoria.text = "Ter ele ao meu lado, e meu dois queridos filhos.";
                        break;
                    case 8:
                        textoHistoria.text = "Eu até mesmo poderia ser chamado de \"bom rei\",\nmas isso basicamente nunca veio de mim";
                        break;
                    case 9:
                        textoHistoria.text += "\nFoi mais uma luta de todas as outras pessoas que me acompanhav...";
                        break;
                    case 10:
                        textoHistoria.color = Color.red;
                        textoHistoria.text = "Hahahahahahaha\nAhhh, a ignorância, como é bela.";
                        break;
                    case 11:
                        textoHistoria.text = "Um rei que não tem a capacidade sequer de escolher entrar na porta\n"
                        + "bastou dizer para virar a direita e feito!";
                        break;
                    case 12:
                        textoHistoria.text = "Morra agora rei tolo!";
                        break;
                    default:
                        textoHistoria.text = "";
                        //Reiniciar o jogo
                        espacos = 0;
                        break;
                }
            }
        }
    }
        private void etapaObjeto2()
    {
        // Dependendo do objeto que encontra e interage na sala
        textoHistoria.text = "Agora eu me lembro.";
    }
    private void etapaObjeto3()
    {
        textoHistoria.text = "Essa é a história de um Rei,\nUm rei que amava muito o seu povo...\nMas o que deveria ser algo bom, levou-lhe a sua ruina.";
    }
    private void etapaObjeto4()
    {
        textoHistoria.text = "Essa é a história de um Rei,\nUm rei que amava muito o seu povo...\nMas o que deveria ser algo bom, levou-lhe a sua ruina.";
    }
    private void etapaObjeto5()
    {
        textoHistoria.text = "Essa é a história de um Rei,\nUm rei que amava muito o seu povo...\nMas o que deveria ser algo bom, levou-lhe a sua ruina.";
    }
    private void etapaObjeto6()
    {
        textoHistoria.text = "Essa é a história de um Rei,\nUm rei que amava muito o seu povo...\nMas o que deveria ser algo bom, levou-lhe a sua ruina.";
    }
    private void etapaObjeto7()
    {
        textoHistoria.text = "Essa é a história de um Rei,\nUm rei que amava muito o seu povo...\nMas o que deveria ser algo bom, levou-lhe a sua ruina.";
    }
}
