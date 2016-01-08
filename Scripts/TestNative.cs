using UnityEngine;
using myS7ProSimLib;

public class TestNative : MonoBehaviour {

    /*
    * Placed s7wspsm.dll in visual studio directory
    * Used tlbimp.exe to generate library DLL
    * place new generated DLL on assets/plugins
    * also note that the DLL is treated as managed code
    */
    public S7ProSimClass ps;
    public bool input_0_0;
    

    void Start () {
        ps = new S7ProSimClass();

        ps.Connect();
        print("State " + ps.GetState());
        ps.SetScanMode(ScanModeConstants.ContinuousScan);

        // Here we pass the ref as an obj, since WriteInputPoint method
        // can take bit, word, dwords, as addresses ref obj can take the
        // for of bool, int, float, etc.
        object refInput0_0 = input_0_0;
                                        
        ps.WriteInputPoint(0, 0, ref refInput0_0);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
