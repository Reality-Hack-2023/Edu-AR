/**
 * @file SpawnCube.cs
 *
 * @author Geoffrey Marhuenda
 *
 * @brief Simple script to spawn a prefab at given position.
 */
using System;
using UnityEngine;

namespace lynx
{
    public class SpawnCube : MonoBehaviour
    {
        [SerializeField] private GameObject m_prefab = null;
        [SerializeField] private GameObject m_hospital = null;
        [SerializeField] private GameObject m_house = null;

        [SerializeField] private GameObject m_factory = null;
        [SerializeField] private GameObject m_farm = null;
        [SerializeField] private GameObject m_police = null;
        [SerializeField] private GameObject m_road = null;
        [SerializeField] private GameObject m_school = null;


        public void SpawnCubeAtPosition(Vector3 pos)
        {
            GameObject obj = Instantiate(m_prefab);
            Vector3 newPos = pos;
            newPos.y += 0.1f;

            obj.transform.position = pos;
        }

        public void SpawnHospAtPosition(Vector3 pos)
        {
            GameObject obj = Instantiate(m_hospital);
            Vector3 newPos = pos;
            newPos.y += 0.1f;

            obj.transform.position = pos;
        }

        public void SpawnHouseAtPosition(Vector3 pos)
        {
            GameObject obj = Instantiate(m_house);
            Vector3 newPos = pos;
            newPos.y += 0.1f;

            obj.transform.position = pos;
        }

        public void SpawnFactoryAtPosition(Vector3 pos)
        {
            GameObject obj = Instantiate(m_factory);
            Vector3 newPos = pos;
            newPos.y += 0.1f;

            obj.transform.position = pos;
        }

        public void SpawnFarmAtPosition(Vector3 pos)
        {
            GameObject obj = Instantiate(m_farm);
            Vector3 newPos = pos;
            newPos.y += 0.1f;

            obj.transform.position = pos;
        }

        public void SpawnRoadAtPosition(Vector3 pos)
        {
            GameObject obj = Instantiate(m_road);
            Vector3 newPos = pos;
            newPos.y += 0.1f;

            obj.transform.position = pos;
        }

        public void SpawnSchoolAtPosition(Vector3 pos)
        {
            GameObject obj = Instantiate(m_school);
            Vector3 newPos = pos;
            newPos.y += 0.1f;

            obj.transform.position = pos;
        }

        public void SpawnPoliceAtPosition(Vector3 pos)
        {
            GameObject obj = Instantiate(m_police);
            Vector3 newPos = pos;
            newPos.y += 0.1f;

            obj.transform.position = pos;
        }
    }
}