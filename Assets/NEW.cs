using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class NEW : MonoBehaviour
{

    public TMP_InputField inputClave;
    public TextMeshProUGUI txtMensaje;
    public TMP_InputField inputUsuario;

    string clave = "tic2025";
    string usuario = "pepegon08";
    // Start is called before the first frame update
    void Start()
    {
        txtMensaje.text = string.Empty;
    }


    public void ComprobarClaveIngresada()
    {
        string claveIngresada = inputClave.text;
        if (claveIngresada != clave)
        {
            txtMensaje.text = "accesp denegado";
            inputClave.text = string.Empty;
            inputUsuario.text = string.Empty;
        }
        else
        {
            txtMensaje.text = "bienvenido";
        }
    }
}