using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class QUIIZZMANAGE : MonoBehaviour
{
    [Header("Varieaveis de painel")]
    public GameObject painelInicio;
    public GameObject painelJogo;

    [Header("Objetos do jogo")]
    public TMP_Text textoTitulo;
    public Image imagemQuizz;
    public TMP_Text textoPergunta;
    public TMP_Text[] textoResposta;

    [Header("Conteúdo das perguntas")]
    public string[] titulos;
    public Sprite[] imagens;
    public string[] perguntas;
    public string[] alternativas1;
    public string[] alternativas2;
    public string[] alternativas3;
    public string[] alternativas4;
    public int[] alternativaCorreta;
    public int perguntaAtual;


    // Start is called before the first frame update
    void Start()
    {
        painelInicio.SetActive(true);
        painelJogo.SetActive(false);
    }

    //Método para iniciar o jogo
    public void IniciarJogo()
    {
        painelInicio.SetActive(false);
        painelJogo.SetActive(false);
        ProximaPergunta(perguntaAtual);
    }
    //Método para fazer perguntas
    public void ProximaPergunta(int numero)
    {
        textoTitulo.text = titulos[numero];
        imagemQuizz.sprite = imagens[numero];
        textoPergunta.text = perguntas[numero];
        textoResposta[0].text = alternativas1[numero];
        textoResposta[1].text = alternativas2[numero];
        textoResposta[2].text = alternativas3[numero];
        textoResposta[3].text = alternativas4[numero];

    }

    //Método para checae as perguntas
    public void ChecarResposta(int numero)
    {

        if (numero == alternativaCorreta[perguntaAtual])
        {
            Debug.Log("Acertou a pergunta" + perguntaAtual + 1);
        }
        else
        {
            Debug.Log("Errou a pergunta " + perguntaAtual + 1);
        }

        perguntaAtual++;

        if (perguntaAtual >= titulos.Length)
        {
            painelInicio.SetActive(true);
            painelJogo.SetActive(false);
            perguntaAtual = 0;
        }
        else
        {
            ProximaPergunta(perguntaAtual);
        }
    } 
}
