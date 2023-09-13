using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.prob.discrete;
using nilnul.prob.rationalMeasure.rationalSample;
using nilnul.prob.rationalProb;
using nilnul.prob.rationalProb.rationalSample;
using System.Numerics;
using N = nilnul.num.natural.Natural_bigInteger;
using nilnul.num.natural;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace test
{
	[TestClass]
	public class Simulation
	{
		[TestMethod]
		public void Sim()
		{
			var proj = nilnul.task.prj.survey_.simulate_.Demo.proj;
			var sim = new nilnul.task.prj.survey_.Simulate(nilnul.task.prj.survey_.simulate_.Demo.proj);
			var cdf =sim.getCdf();

			///todo: double to rational in range
			///cpm path
			var densities = cdf.densities(1000);


			var keys = densities.Keys;
			var densitiesFirst = densities.First();
			var last = densities.Last();
			var count = densities.Count;

			var values = densities.Values;
			var valuesMax = values.Select(c=>c.val).Max();
			var valuesMin = values.Select(c=>c.val).Min();

			var mean = cdf.meanInDouble;

		}
	}
}
