// <copyright file="Monkey.cs" company="MyMonkeyAppMCP">
// Copyright (c) MyMonkeyAppMCP. All rights reserved.
// </copyright>

namespace MyMonkeyApp;

/// <summary>
/// Represents a monkey species with relevant data.
/// </summary>
public class Monkey
{
	/// <summary>
	/// Gets or sets the name of the monkey species.
	/// </summary>
	public string Name { get; set; } = string.Empty;


	/// <summary>
	/// Gets or sets the location where the monkey species is found.
	/// </summary>
	public string Location { get; set; } = string.Empty;

	/// <summary>
	/// Gets or sets the latitude of the monkey species location.
	/// </summary>
	public double? Latitude { get; set; }

	/// <summary>
	/// Gets or sets the longitude of the monkey species location.
	/// </summary>
	public double? Longitude { get; set; }

	/// <summary>
	/// Gets or sets the estimated population of the monkey species.
	/// </summary>
	public int Population { get; set; }

	/// <summary>
	/// Gets or sets the ASCII art representing the monkey species.
	/// </summary>
	public string? AsciiArt { get; set; }

	/// <summary>
	/// Gets or sets the image path for the monkey species.
	/// </summary>
	public string? ImagePath { get; set; }

	/// <summary>
	/// Gets or sets additional details about the monkey species.
	/// </summary>
	public string? Details { get; set; }
}
