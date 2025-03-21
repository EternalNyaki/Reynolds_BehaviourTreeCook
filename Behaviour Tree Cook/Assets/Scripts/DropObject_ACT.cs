using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;


namespace NodeCanvas.Tasks.Actions
{

	public class DropObject_ACT : ActionTask
	{

		private Transform _spawnPoint;

		//Use for initialization. This is called only once in the lifetime of the task.
		//Return null if init was successfull. Return an error string otherwise
		protected override string OnInit()
		{
			_spawnPoint = agent.transform.GetChild(0);

			return null;
		}

		//This is called once each time the task is enabled.
		//Call EndAction() to mark the action as finished, either in success or failure.
		//EndAction can be called from anywhere.
		protected override void OnExecute()
		{
			foreach (Transform child in _spawnPoint)
			{
				GameObject.Destroy(child.gameObject);
			}
			EndAction(true);
		}

		//Called once per frame while the action is active.
		protected override void OnUpdate()
		{

		}

		//Called when the task is disabled.
		protected override void OnStop()
		{

		}

		//Called when the task is paused.
		protected override void OnPause()
		{

		}
	}
}