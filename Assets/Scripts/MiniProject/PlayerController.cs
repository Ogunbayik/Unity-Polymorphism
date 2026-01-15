using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float _movementSpeed;
    private QuestsManager _questManager;

    private Vector3 _movementDirection;
    private Vector3 _rayOffset = new Vector3(0, 0.5f, 0);
    private float _interactRange = 2f;
    private void Awake()
    {
        _questManager = GetComponent<QuestsManager>();
    }
    void Update()
    {
        HandleMovement();

        Ray ray = new Ray(transform.position + _rayOffset, transform.forward * _interactRange);
        if(Physics.Raycast(ray, out RaycastHit hit,_interactRange))
        {
            if(hit.transform.TryGetComponent<Farmer>(out Farmer farmer))
            {
                if(farmer != null && Input.GetKeyDown(KeyCode.E))
                {
                    var questData = farmer.QuestData;
                    QuestStatus newQuest = new QuestStatus(questData);
                    _questManager.AddQuest(newQuest);
                }
            }

        }

    }
    private void HandleMovement()
    {
        var horizontal = Input.GetAxis("Horizontal");
        var vertical = Input.GetAxis("Vertical");
        _movementDirection.Set(horizontal, 0f, vertical);

        transform.Translate(_movementDirection * _movementSpeed * Time.deltaTime);

    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.black;

        Gizmos.DrawRay(transform.position + _rayOffset, transform.forward * _interactRange);
    }
}
