using System.Collections.Generic;
using NodeCanvas.Framework;
using ParadoxNotion.Design;


namespace NodeCanvas.Tasks.Conditions
{

	public class IngredientType_CDT : ConditionTask
	{

		public Ingredient ingredient;

		public BBParameter<List<Ingredient>> recipe;
		public int recipeIndex;

		//Use for initialization. This is called only once in the lifetime of the task.
		//Return null if init was successfull. Return an error string otherwise
		protected override string OnInit()
		{
			return null;
		}

		//Called whenever the condition gets enabled.
		protected override void OnEnable()
		{

		}

		//Called whenever the condition gets disabled.
		protected override void OnDisable()
		{

		}

		//Called once per frame while the condition is active.
		//Return whether the condition is success or failure.
		protected override bool OnCheck()
		{
			return ingredient == recipe.value[recipeIndex];
		}
	}
}