using UnityEngine;
using UnityEngine.UI;

public class SistemaBotones : MonoBehaviour
{
    public Button boton1, boton2, boton3;
    public GameObject imagenCodigo;
    public Button botonCerrar;
    
  
    private bool click1 = false;
    private bool click2 = false;
    private bool click3 = false;
    
    void Start()
    {
        
        imagenCodigo.SetActive(false);
    }
    
    
    public void ClickBoton1() { click1 = true; Verificar(); }
    public void ClickBoton2() { click2 = true; Verificar(); }
    public void ClickBoton3() { click3 = true; Verificar(); }
    
    void Verificar()
    {
        if (click1 && click2 && click3)
        {
            imagenCodigo.SetActive(true);
        }
    }
    
    
    public void CerrarImagen()
    {
        
        imagenCodigo.SetActive(false);
        
        
        click1 = false;
        click2 = false;
        click3 = false;
        
        Debug.Log("Cerrado y reiniciado. click1=" + click1 + " click2=" + click2 + " click3=" + click3);
    }
}