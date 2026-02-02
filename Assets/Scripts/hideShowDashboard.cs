using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/**
 *                  .________________._____
 *                /~~~~~~~//~~~~~~~~//~~~~~|
 *               /       //        //      |
 *              /_\.___ //__ \.___//_______|
 *    O       [%%%%%%%%%] O=====] |[_______]
 *   __\__ ===========___/_ --------}==========================
 *  |**   |/|(@ ## (@|   **|        |     []|                  |)
 *  |     |/| ###### |     | _____  |       |         ___      |
 *  |_____|/|_######_|____ |/_  _  \}_______|________/_  _\    |.
 * |________________________|     \ \_______________//     \\ /
 *   |%{  @  }            |%{  @  }                |%{  @  }
 *    \%\   /              \%\   /                  \%\   /
 *      ~~~~                 ~~~~                     ~~~~   
 * Shows / Hides Dashboard with Turning Wheel
 * En los Juegos se vale poner cualquier cosa hijueputa
 * modificaciones de junta directiva , estupideces de contadores playos
 * Los LandRover son de Aluminio, el Jeep willys es un fierro , PIENSELO!!
 *
 * Los Drones de Control Remoto son aviones de control remoto, no son drones, solo son plataformas posibles
 * encontrando los canales del receptor e instalando un relay con USB a un android montado en el dron para que sea una
 * computadora con un control autonomo, el Android tiene shell de Unix pero solo va a volar dentro del rango antenado 
 *   TOME CAFE 1820 o pagueme a ver como sirve el radar buscando gases bajo tierra, luego polarize el LandRover y lo pasa por ahi ....
 * Necesito $300mil para pagar el major en el MIT
 *
 *
 *
 * @author Rolando <rgarro@gmail.com> <https://emptyart.github.io>
 */
public class hideShowDashboard : MonoBehaviour
{
 
    public GameObject dashboard;
    public Texture2D dashboardIcon;
    protected bool dashboard_is_on = true;
    //button centering ...
    public int buttons_x_corner = 25;
    public int buttons_y_corner = 25;
    public int buttonWidth = 40;
    public int buttonHeight = 40;
    public string childrenTag = "gauges";
    private GameObject[] gauges;
 
    // Start is called before the first frame update
    void Start()
    {
        this.dashboard.SetActive(true);
        this.gauges =  GameObject.FindGameObjectsWithTag(this.childrenTag);
    }

    void activateDash(){
        
        for (int i = 0; i < this.gauges.Length; i++){
            //Debug.Log("dashboard object "+i);
            this.gauges[i].SetActive(true);
        }
        this.dashboard.SetActive(true);
    }

    void deactivateDash(){
        //this.gauges =  GameObject.FindGameObjectsWithTag(this.childrenTag);
        for (int i = 0; i < this.gauges.Length; i++){
            this.gauges[i].SetActive(false);
        }
        this.dashboard.SetActive(false);
    }

     void OnGUI(){
        if(GUI.Button(new Rect(this.buttons_x_corner,this.buttons_y_corner,this.buttonWidth,this.buttonHeight), this.dashboardIcon)) 
        {
               if(this.dashboard_is_on){
                //Debug.Log("dashboard on click ...");
                this.deactivateDash();
                //this.dashboard.SetActive(false);
                this.dashboard_is_on = false;
            } else {
                //Debug.Log("dashboard off click ...");
                this.activateDash();
                //this.dashboard.SetActive(true);
                this.dashboard_is_on = true;
            }
        }		
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
