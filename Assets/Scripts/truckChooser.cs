using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/**
 *           o x o x o x o . . .
 *         o      _____            _______________ ___=====__T___
 *       .][__n_n_|DD[  ====_____  |    |.\/.|   | |   |_|     |_
 *      >(________|__|_[_________]_|____|_/\_|___|_|___________|_|
 *      _/oo OOOOO oo`  ooo   ooo   o^o       o^o   o^o     o^o
 *   -+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-
 *  Button Navigator Allowing to swap among 4 vehicles
 * and starts its main cameras
 * 
 *
 *
 * @author Rolando<rgarro@gmail.com> <https://emptyart.github.io>
 */
public class truckChooser : MonoBehaviour
{
    public string backHoeTag = "backHoeTag";
    public string loaderTag = "loaderTag";
    public string caterpillarTag = "catTag";
    public string truckTag = "loaderTag";

    protected bool loader_is_on = false;
    protected bool backHoe_is_on = false;
    protected bool caterpillar_is_on = false;
    protected bool truck_is_on = false;//vagoneta primero

    public GUISkin btnSkin;
    public Texture2D backHoeIcon;
    public Texture2D loaderIcon;
    public Texture2D caterpillarIcon;
    public Texture2D truckIcon;

    public int buttons_x_corner = 150;

    public GameObject backHoe;
public GameObject backHoeCamera;

    public GameObject loader;
public GameObject loaderCamera;

    public GameObject caterpillar;
public GameObject caterpillarCamera;

    public GameObject truck;
 public GameObject truckCamera;//la camara anidada en gm scripts no prendia , necesitaba su relay   

    public int boxWidth = 265;
    public int boxHeight = 90;
    public int boxY = 10;
    public int buttonWidth = 40;
    public int buttonHeight = 40;
    public int buttonY = 40;
    public string boxLabel = "Truck Chooser";
    public int spaceXCornerFromFirst = 55;




    // Start is called before the first frame update
    void Start()
    {
        this.truck.SetActive(true);//Vagoneta primero
        
        this.backHoe.SetActive(false);
        this.backHoeCamera.SetActive(false);

        this.caterpillar.SetActive(false);
        this.caterpillarCamera.SetActive(false);

        this.loader.SetActive(false);
        this.loaderCamera.SetActive(false);      
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnGUI(){
        GUI.skin = this.btnSkin;
        GUI.Box(new Rect(this.buttons_x_corner,this.boxY,this.boxWidth,this.boxHeight), this.boxLabel);
        //boton Vagoneta
        if(GUI.Button(new Rect(this.buttons_x_corner+this.spaceXCornerFromFirst,this.buttonY,this.buttonWidth,this.buttonHeight), this.truckIcon)){
            if(!this.truck_is_on){
                this.truck.SetActive(true);//Vagoneta primero
                this.backHoe.SetActive(false);
                this.caterpillar.SetActive(false);
                this.loader.SetActive(false);
                this.truck_is_on = true;
                this.loader_is_on = false;
                this.backHoe_is_on = false;
                this.caterpillar_is_on = false;   
            }
        }
        //boton Caterpillar 
        if(GUI.Button(new Rect(this.buttons_x_corner+this.spaceXCornerFromFirst+55,this.buttonY,this.buttonWidth,this.buttonHeight), this.caterpillarIcon)){
            if(!this.caterpillar_is_on){
                this.truck.SetActive(false);
                this.backHoe.SetActive(false);
                this.caterpillar.SetActive(true);//caterpillar
                this.loader.SetActive(false);
                this.truck_is_on = false;
                this.loader_is_on = false;
                this.backHoe_is_on = false;
                this.caterpillar_is_on = true;   
            }
        }
        //boto loader
        if(GUI.Button(new Rect(this.buttons_x_corner+this.spaceXCornerFromFirst+160,this.buttonY,this.buttonWidth,this.buttonHeight), this.backHoeIcon)){
            if(!this.loader_is_on){
                this.truck.SetActive(false);
                this.backHoe.SetActive(false);
                this.caterpillar.SetActive(false);
                this.loader.SetActive(true);
                this.truck_is_on = false;
                this.loader_is_on = true;//loader
                this.backHoe_is_on = false;
                this.caterpillar_is_on = true;   
            }
        }
        //boton backhoe
        if(GUI.Button(new Rect(this.buttons_x_corner+this.spaceXCornerFromFirst+105,this.buttonY,this.buttonWidth,this.buttonHeight), this.loaderIcon)){
            if(!this.loader_is_on){
                this.truck.SetActive(false);
                this.backHoe.SetActive(true);
                this.caterpillar.SetActive(false);
                this.loader.SetActive(false);
                this.truck_is_on = false;
                this.loader_is_on = false;
                this.backHoe_is_on = false;//backhoe
                this.caterpillar_is_on = true;   
            }
        }
    }
}
