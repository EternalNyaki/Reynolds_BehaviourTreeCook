using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;
using UnityEngine.AI;


namespace NodeCanvas.Tasks.Actions
{

	public class GoToPoint_ACT : ActionTask
	{

		public Transform point;

		private NavMeshAgent _navAgent;

		//Use for initialization. This is called only once in the lifetime of the task.
		//Return null if init was successfull. Return an error string otherwise
		protected override string OnInit()
		{
			_navAgent = agent.GetComponent<NavMeshAgent>();

			return null;
		}

		//This is called once each time the task is enabled.
		//Call EndAction() to mark the action as finished, either in success or failure.
		//EndAction can be called from anywhere.
		protected override void OnExecute()
		{
			NavMeshHit hit;
			if (NavMesh.SamplePosition(point.position, out hit, 100f, NavMesh.AllAreas))
			{
				_navAgent.destination = hit.position;
			}
			else
			{
				EndAction(false);
			}
		}

		//Called once per frame while the action is active.
		protected override void OnUpdate()
		{
			if (!_navAgent.hasPath)
			{
				EndAction(true);
			}
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