using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HistoryController : MonoBehaviour
{
    public Text textoHistoria;
    private int espacos;
    public static int historia;
    public GameObject bulletPrefab;
    public Transform bulletSpawn;
    // Start is called before the first frame update
    void Start()
    {
        espacos = 0;
        historia = 0;
        textoHistoria.text = "Essa é a história de um Rei,\nUm rei que amava muito o seu povo...\nMas o que deveria ser algo bom, levou-lhe a sua ruina. "
        + "\n\n\n(Aperte ENTER para continuar)";
    }

    private void fire()
    {
        var bullet = (GameObject)Instantiate(bulletPrefab, bulletSpawn.position, bulletSpawn.rotation);
        bullet.GetComponent<Rigidbody>().velocity = bullet.transform.forward * 10f;

        Destroy(bullet, 0.1f);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            fire();
            semiController();
        }
    }

    private void semiController()
    {
        if (historia == 0)
        {
            comeco();
        }
        if (historia == 1)
        {
            historia1();
        }
        else if (historia == 2)
        {
            historia2();
        }
        else if (historia == 3)
        {
            historia3();
        }
        else if (historia == 4)
        {
            historia4();
        }
    }
    public void ReiniciaFase()
    {
        Scene cena = SceneManager.GetActiveScene();
        SceneManager.LoadScene(cena.name);
    }

    private void comeco()
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
                espacos = 1000;
                break;
        }
    }

    // Rei
    private void historia1()
    {
        textoHistoria.text = "Sim... De alguma forma reconheço este lugar...\n\nEssas roupas...";
        if (espacos >= 500)
            espacos = 0;
        espacos++;
        switch (espacos)
        {
            case 1:
                textoHistoria.text = "Sim... De alguma forma reconheço este lugar...\n\nEssas roupas...";
                break;
            case 2:
                textoHistoria.text = "Essas são as roupas do meu fiel conselheiro...";
                break;
            case 3:
                textoHistoria.text += "\nEu sempre quis agradecê-lo";
                break;
            case 4:
                textoHistoria.text = "Mesmo após a morte de minha esposa, ele sempre me ajudou a superar tudo.";
                break;
            case 5:
                textoHistoria.text = "Sempre me ajudou a focar em meus objetivos e no trabalho como governante.";
                break;
            case 6:
                textoHistoria.text = "Por mais que possa ter sido difícil por vezes, foi isso que me manteve de pé.";
                break;
            case 7:
                textoHistoria.text = "Ter ele ao meu lado, e meu dois queridos filhos.";
                break;
            case 8:
                textoHistoria.text = "Eu até mesmo poderia ser chamado de \"bom rei\",\nmas isso basicamente nunca veio de mim.";
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
            case 13:
                textoHistoria.text = "Quem é você que não consegue tomar suas próprias decisões?";
                break;
            case 14:
                textoHistoria.text = "Pense por si mesmo.";
                break;
            default:
                textoHistoria.text = "";
                textoHistoria.color = Color.white;
                ReiniciaFase();
                espacos = 0;
                break;
        }
    }

    // Esposa
    private void historia2()
    {
        if (espacos >= 500)
            espacos = 0;
        espacos++;
        switch (espacos)
        {
            case 1:
                textoHistoria.text = "Waaaaaaaaaaa!!!!";
                break;
            case 2:
                textoHistoria.text = "Onde está meu rosto? Esse espelho está quebrado certo?";
                break;
            case 3:
                textoHistoria.color = Color.red;
                textoHistoria.text = "Eu tento tocar o espelho, quebrá-lo talvez.";
                break;
            case 4:
                textoHistoria.text = "Mas foi pior assim...";
                break;
            case 5:
                textoHistoria.color = Color.white;
                textoHistoria.text = "Eu não tenho mãos!";
                break;
            case 6:
                textoHistoria.text = "O que sou?\nO que sou?\nO que sou?";
                break;
            case 7:
                textoHistoria.text = "O que sou?\nO que sou?\nO que sou?";
                break;
            case 8:
                textoHistoria.text = "Sou eu apenas um fantasma?";
                break;
            case 9:
                textoHistoria.color = Color.red;
                textoHistoria.text = "Não se assuma tão valiosa assim, você não chega perto do valor de um.";
                break;
            case 10:
                textoHistoria.text = "Você é mais um brinquedo, apenas um jogo que para algumas pessoas... é divertido, certo?";
                break;
            case 11:
                textoHistoria.text = "Mas não tema tanto, todos participamos de um jogo, querendo ou não.";
                break;
            case 12:
                textoHistoria.text = "Um jogo com o único objetivo de sobreviver, passar cada dia.";
                break;
            case 13:
                textoHistoria.text = "Extresse, ansiedade...";
                break;
            case 14:
                textoHistoria.text = "Uff... " +
                "Como é não ter suas \"armas\"? Vá pegá-las, é o melhor!";
                break;
            default:
                textoHistoria.text = "";
                textoHistoria.color = Color.white;
                //Reiniciar o jogo
                espacos = 0;
                break;
        }
    }

    private void historia3()
    {
        if (espacos >= 500)
            espacos = 0;
        espacos++;
        switch (espacos)
        {
            case 1:
                textoHistoria.text = "Céu escuro\nMas ainda há aquele sol infernal\nContinua a nos irritar.";
                break;
            case 2:
                textoHistoria.text = "Todos queremos este soro!\nPara viver juntamente ao mal\nContinuar a matar.";
                break;
            case 3:
                textoHistoria.text = "Como filho mais novo\nA culpa pela mãe sempre foi deixada a ele\nO único que se arriscaria por ela.";
                break;
            case 4:
                textoHistoria.text = "Mas neste mundo não há tempo que retorne\nEspero que você ouça de verdade essas \"coisas\"";
                break;
            case 5:
                textoHistoria.text = "Como filho de minha mãe, gostaria de evitar mortes!";
                break;
            case 6:
                textoHistoria.color = Color.red;
                textoHistoria.text = "Mas mortes por si só não são evitáveis, alguma hora teremos nosso fatídico dia,";
                break;
            case 7:
                textoHistoria.text = "E a carne que comias todo dia?\nComo pode odiar a morte, se a comida em sua mesa era proporcionada por ela?";
                break;
            case 8:
                textoHistoria.text = "A vida é complicada, e não ser capaz de superar certos problemas...";
                break;
            case 9:
                textoHistoria.text = "Isso sim, pode te levar a uma morte prematura, ou ainda pior...";
                break;
            case 10:
                textoHistoria.text = "Agora... ACORDE!";
                break;
            default:
                textoHistoria.text = "";
                textoHistoria.color = Color.white;
                //Reiniciar o jogo
                espacos = 0;
                break;
        }
    }
    private void historia4()
    {
        if (espacos >= 500)
            espacos = 0;
        espacos++;
        switch (espacos)
        {
            case 1:
                textoHistoria.text = "De quem é este quarto nojento?";
                break;
            case 2:
                textoHistoria.text = "Huh, sinceramente, quem teria a coragem de dormir numa cama suja assim?";
                break;
            case 3:
                textoHistoria.text = "Oh, mas há um piano?";
                break;
            case 4:
                textoHistoria.text = "Ainda há um pouco de bom gosto ainda...";
                break;
            case 5:
                textoHistoria.text = "E acho q deveria ter me feito esta pergunta antes... Mas onde está minha mão?";
                break;
            case 6:
                textoHistoria.text = "Eu sequer consigo mecher minha cabeça?";
                break;
            case 7:
                textoHistoria.text = "Meu corpo se foi, ou o quê?";
                break;
            case 8:
                textoHistoria.text = "EDe qualquer forma, acho que devo ter sido liberto então?";
                break;
            case 9:
                textoHistoria.color = Color.red;
                textoHistoria.text = "O que significa ser liberto? Significa que você não mais fará o que os outros querem?";
                break;
            case 10:
                textoHistoria.text = "Significa que você pode agora fazer algo, mas com outro custo?";
                break;
            case 11:
                textoHistoria.text = "Então pergunto... Sinceramente, o que é liberdade?";
                break;
            case 12:
                textoHistoria.text = "A morte pode ser, na verdade, a maior liberdade para algumas pessoas.";
                break;
            case 13:
                textoHistoria.text = "Mas ficar parado para todo o sempre, com vermes te consumindo, até que não haja restos";
                break;
            case 14:
                textoHistoria.text = "Isso é liberdade?";
                break;
            case 15:
                textoHistoria.text = "Então pode tê-la.";
                break;
            default:
                textoHistoria.text = "";
                textoHistoria.color = Color.white;
                //Reiniciar o jogo
                espacos = 0;
                break;
        }
    }
}
