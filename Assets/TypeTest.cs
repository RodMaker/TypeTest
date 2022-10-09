using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TypeTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        bool a, b, c, d;

        a = true;
        b = false;
        c = a && b;
        d = a || b;

        Debug.Log($"a,b,c,d = {a} {b} {c} {d}");

        a = 3 < 4;
        b = 3 > 4;
        c = (5 == 7) || (15 == 15);
        d = !(5 <= 6);

        Debug.Log($"a,b,c,d = {a} {b} {c} {d}");

        char ac, bc, cc;
        ac = 'A';
        bc = (char)(ac + 1);
        cc = (char)(ac + 32);

        Debug.Log($"ac,bc,cc = {ac} {bc} {cc}");

        string mystring;
        mystring = "Testing ONE TWO THREE";

        Debug.Log(mystring);
        Debug.Log(mystring.ToLower());

        int[] myarray = new int[5] { 1, 4, 9, 16, 25 };
        Debug.Log($"array elements 0 and 1: {myarray[0]} {myarray[1]}");

        myarray[0] = 17;
        myarray[1] = myarray[2] * myarray[3];
        Debug.Log($"array elements 0 and 1: {myarray[0]} {myarray[1]}");

        float[,] My2dimArray = new float[3, 4];
        My2dimArray[0, 0] = 1.0f;
        My2dimArray[1, 0] = 2.3f;
        My2dimArray[2, 3] = 4.34f;
        Debug.Log($"two dim array [1 0] : {My2dimArray[1, 0]}");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
