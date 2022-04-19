using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LOSTRESGUSTOS : MonoBehaviour
{

    public string GustoHelado;
    public int CantidadHelado;
    int helado;
    int PrecioPedido;
    int PrecioPedidoFinal;
    int PrecioPromocion;
    int Promocion;
    int PromocionFinal;

    // Start is called before the first frame update
    void Start()
    {
        if (GustoHelado == "CHO" || GustoHelado == "DDL" || GustoHelado == "FRU")
        {
            if(GustoHelado == "CHO" || GustoHelado == "DDL")
            { 
                if (CantidadHelado > 250 || CantidadHelado < 3000)
                {
                    PrecioPedido = CantidadHelado * 500;
                    PrecioPedidoFinal = PrecioPedido / 1000;
                    Debug.Log("El precio de su pedido es " +PrecioPedidoFinal);
                }
            }
            if (GustoHelado == "FRU")
            {
                if (CantidadHelado > 250 || CantidadHelado < 3000)
                {
                    PrecioPedido = CantidadHelado * 500;
                    PrecioPedidoFinal = PrecioPedido / 1000;

                    Promocion = PrecioPedidoFinal * 10;
                    PromocionFinal = Promocion / 100;

                    PrecioPromocion = PrecioPedidoFinal - PromocionFinal;
                    Debug.Log("El precio de su pedido es "+PrecioPromocion);
                }
            }
        }
        else
        {
            if(! (GustoHelado == "CHO") || ! (GustoHelado == "DDL") || ! (GustoHelado == "FRU"))
            {
                Debug.Log("Ingrese un Codigo de helado correcto.");
            }
            if(CantidadHelado < 250 || CantidadHelado < 3000)
            {
                Debug.Log("Ingrese una cantidad correcta de helado (Minimo 250 gr, maximo 3000 gr)");
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
