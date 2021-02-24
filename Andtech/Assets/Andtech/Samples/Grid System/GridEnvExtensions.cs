﻿using UnityEngine;

namespace Andtech {

	public static class GridEnvExtensions {

		/// <summary>
		/// Converts a world space position to cell coordinates.
		/// </summary>
		/// <param name="world">The world space coordinates</param>
		/// <returns>The cell coordinates (integer).</returns>
		public static Vector3Int Quantize(this GridEnv env, Vector3 world) {
			var local = env.InverseTransformPoint(world);
			var cell = new Vector3Int {
				x = Mathf.FloorToInt(local.x),
				y = Mathf.RoundToInt(local.y),
				z = Mathf.FloorToInt(local.z)
			};

			return cell;
		}
	}
}