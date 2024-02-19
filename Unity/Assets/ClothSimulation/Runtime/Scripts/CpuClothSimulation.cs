using Sirenix.OdinInspector;
using UnityEngine;

namespace ClothSimulation.Runtime
{
    public class CpuClothSimulation : MonoBehaviour
    {
        #region Cloth质点生成
        
        public GameObject m_InitGo;
        public GameObject m_ClothGo;

        [Button("生成预制体")]
        public void Instantiate()
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    var go = GameObject.Instantiate(m_InitGo, new Vector3(i * 2f, j * 2f, 0), Quaternion.identity);
                    go.transform.SetParent(m_ClothGo.transform);
                    go.SetActive(true);
                }
            }
        }
        
        #endregion
        
        
        
    }
}