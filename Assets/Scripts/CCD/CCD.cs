using System.Linq;
using UnityEngine;

public class CCD : MonoBehaviour
{
    [SerializeField] private Transform target;

    [SerializeField] private Transform[] arms;

    [SerializeField] private Transform armTip;

    void Start()
    {

    }


    void Update()
    {
        TipToTarget ();
    }

    void TipToTarget()
    {
        Vector3 line;
        Vector3 selfLine;
        float alpha;
        Vector3 eje;

        for (int i = 0; i < arms.Length; i++)
        {
            line = (target.position - arms[i].position).normalized;
            selfLine =  (armTip.position - arms[i].position).normalized;

            alpha = Mathf.Acos(Vector3.Dot(line, selfLine));

            eje = Vector3.Cross(line, selfLine);
            

            arms[i].transform.Rotate(eje, alpha);
        }

    }
}
