#if true
using System;
using MIU;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityEngine.Rendering;


public partial class SerializerHelper {


	public void Write(ParticleSystem value)
	{
		
		// Property startDelay from ParticleSystem
		
		// Property isPlaying from ParticleSystem
		
		// Property isEmitting from ParticleSystem
		
		// Property isStopped from ParticleSystem
		
		// Property isPaused from ParticleSystem
		
		// Property loop from ParticleSystem
		
		// Property playOnAwake from ParticleSystem
		
		// Property time from ParticleSystem
		Stream.WriteSingle(value.time);
		
		// Property duration from ParticleSystem
		
		// Property playbackSpeed from ParticleSystem
		
		// Property particleCount from ParticleSystem
		
		// Property enableEmission from ParticleSystem
		
		// Property emissionRate from ParticleSystem
		
		// Property startSpeed from ParticleSystem
		
		// Property startSize from ParticleSystem
		
		// Property startColor from ParticleSystem
		
		// Property startRotation from ParticleSystem
		
		// Property startRotation3D from ParticleSystem
		
		// Property startLifetime from ParticleSystem
		
		// Property gravityModifier from ParticleSystem
		
		// Property maxParticles from ParticleSystem
		
		// Property simulationSpace from ParticleSystem
		
		// Property scalingMode from ParticleSystem
		
		// Property randomSeed from ParticleSystem
		Stream.WriteUInt32(value.randomSeed);
		
		// Property useAutoRandomSeed from ParticleSystem
		Stream.WriteBoolean(value.useAutoRandomSeed);
		
		// Property main from ParticleSystem
		Write(value.main);
		
		// Property emission from ParticleSystem
		Write(value.emission);
		
		// Property shape from ParticleSystem
		Write(value.shape);
		
		// Property velocityOverLifetime from ParticleSystem
		Write(value.velocityOverLifetime);
		
		// Property limitVelocityOverLifetime from ParticleSystem
		Write(value.limitVelocityOverLifetime);
		
		// Property inheritVelocity from ParticleSystem
		Write(value.inheritVelocity);
		
		// Property forceOverLifetime from ParticleSystem
		Write(value.forceOverLifetime);
		
		// Property colorOverLifetime from ParticleSystem
		Write(value.colorOverLifetime);
		
		// Property colorBySpeed from ParticleSystem
		Write(value.colorBySpeed);
		
		// Property sizeOverLifetime from ParticleSystem
		Write(value.sizeOverLifetime);
		
		// Property sizeBySpeed from ParticleSystem
		Write(value.sizeBySpeed);
		
		// Property rotationOverLifetime from ParticleSystem
		Write(value.rotationOverLifetime);
		
		// Property rotationBySpeed from ParticleSystem
		Write(value.rotationBySpeed);
		
		// Property externalForces from ParticleSystem
		Write(value.externalForces);
		
		// Property noise from ParticleSystem
		Write(value.noise);
		
		// Property collision from ParticleSystem
		Write(value.collision);
		
		// Property trigger from ParticleSystem
		Write(value.trigger);
		
		// Property subEmitters from ParticleSystem
		Write(value.subEmitters);
		
		// Property textureSheetAnimation from ParticleSystem
		Write(value.textureSheetAnimation);
		
		// Property lights from ParticleSystem
		Write(value.lights);
		
		// Property trails from ParticleSystem
		Write(value.trails);
		
		// Property customData from ParticleSystem
		Write(value.customData);
		
		// Property safeCollisionEventSize from ParticleSystem
		
		// Property transform from Component
		
		// Property gameObject from Component
		
		// Property tag from Component
		
		// Property rigidbody from Component
		
		// Property rigidbody2D from Component
		
		// Property camera from Component
		
		// Property light from Component
		
		// Property animation from Component
		
		// Property constantForce from Component
		
		// Property renderer from Component
		
		// Property audio from Component
		
		// Property guiText from Component
		
		// Property networkView from Component
		
		// Property guiElement from Component
		
		// Property guiTexture from Component
		
		// Property collider from Component
		
		// Property collider2D from Component
		
		// Property hingeJoint from Component
		
		// Property particleEmitter from Component
		
		// Property particleSystem from Component
		
		// Property name from Object
		
		// Property hideFlags from Object
	}


	public void Write(ParticleSystem.MainModule value)
	{
		
		// Property duration from MainModule
		Stream.WriteSingle(value.duration);
		
		// Property loop from MainModule
		Stream.WriteBoolean(value.loop);
		
		// Property prewarm from MainModule
		Stream.WriteBoolean(value.prewarm);
		
		// Property startDelay from MainModule
		Write(value.startDelay);
		
		// Property startDelayMultiplier from MainModule
		Stream.WriteSingle(value.startDelayMultiplier);
		
		// Property startLifetime from MainModule
		Write(value.startLifetime);
		
		// Property startLifetimeMultiplier from MainModule
		Stream.WriteSingle(value.startLifetimeMultiplier);
		
		// Property startSpeed from MainModule
		Write(value.startSpeed);
		
		// Property startSpeedMultiplier from MainModule
		Stream.WriteSingle(value.startSpeedMultiplier);
		
		// Property startSize3D from MainModule
		Stream.WriteBoolean(value.startSize3D);
		
		// Property startSize from MainModule
		Write(value.startSize);
		
		// Property startSizeMultiplier from MainModule
		Stream.WriteSingle(value.startSizeMultiplier);
		
		// Property startSizeX from MainModule
		Write(value.startSizeX);
		
		// Property startSizeXMultiplier from MainModule
		Stream.WriteSingle(value.startSizeXMultiplier);
		
		// Property startSizeY from MainModule
		Write(value.startSizeY);
		
		// Property startSizeYMultiplier from MainModule
		Stream.WriteSingle(value.startSizeYMultiplier);
		
		// Property startSizeZ from MainModule
		Write(value.startSizeZ);
		
		// Property startSizeZMultiplier from MainModule
		Stream.WriteSingle(value.startSizeZMultiplier);
		
		// Property startRotation3D from MainModule
		Stream.WriteBoolean(value.startRotation3D);
		
		// Property startRotation from MainModule
		Write(value.startRotation);
		
		// Property startRotationMultiplier from MainModule
		Stream.WriteSingle(value.startRotationMultiplier);
		
		// Property startRotationX from MainModule
		Write(value.startRotationX);
		
		// Property startRotationXMultiplier from MainModule
		Stream.WriteSingle(value.startRotationXMultiplier);
		
		// Property startRotationY from MainModule
		Write(value.startRotationY);
		
		// Property startRotationYMultiplier from MainModule
		Stream.WriteSingle(value.startRotationYMultiplier);
		
		// Property startRotationZ from MainModule
		Write(value.startRotationZ);
		
		// Property startRotationZMultiplier from MainModule
		Stream.WriteSingle(value.startRotationZMultiplier);
		
		// Property randomizeRotationDirection from MainModule
		Stream.WriteSingle(value.randomizeRotationDirection);
		
		// Property startColor from MainModule
		Write(value.startColor);
		
		// Property gravityModifier from MainModule
		Write(value.gravityModifier);
		
		// Property gravityModifierMultiplier from MainModule
		Stream.WriteSingle(value.gravityModifierMultiplier);
		
		// Property simulationSpace from MainModule
		Write(value.simulationSpace);
		
		// Property customSimulationSpace from MainModule
		
		// Property simulationSpeed from MainModule
		Stream.WriteSingle(value.simulationSpeed);
		
		// Property useUnscaledTime from MainModule
		Stream.WriteBoolean(value.useUnscaledTime);
		
		// Property scalingMode from MainModule
		Write(value.scalingMode);
		
		// Property playOnAwake from MainModule
		Stream.WriteBoolean(value.playOnAwake);
		
		// Property maxParticles from MainModule
		Stream.WriteInt32(value.maxParticles);
		
		// Property emitterVelocityMode from MainModule
		Write(value.emitterVelocityMode);
		
		// Property stopAction from MainModule
		Write(value.stopAction);
	}


	public void Write(ParticleSystem.MinMaxCurve value)
	{
		
		// Property mode from MinMaxCurve
		Write(value.mode);
		
		// Property curveScalar from MinMaxCurve
		
		// Property curveMultiplier from MinMaxCurve
		Stream.WriteSingle(value.curveMultiplier);
		
		// Property curveMax from MinMaxCurve
		Write(value.curveMax);
		
		// Property curveMin from MinMaxCurve
		Write(value.curveMin);
		
		// Property constantMax from MinMaxCurve
		Stream.WriteSingle(value.constantMax);
		
		// Property constantMin from MinMaxCurve
		Stream.WriteSingle(value.constantMin);
		
		// Property constant from MinMaxCurve
		Stream.WriteSingle(value.constant);
		
		// Property curve from MinMaxCurve
		Write(value.curve);
	}


	public void Write(ParticleSystemCurveMode value)
	{
		Stream.WriteInt32((int)value);
	}


	public void Write(ParticleSystem.MinMaxGradient value)
	{
		
		// Property mode from MinMaxGradient
		Write(value.mode);
		
		// Property gradientMax from MinMaxGradient
		Write(value.gradientMax);
		
		// Property gradientMin from MinMaxGradient
		Write(value.gradientMin);
		
		// Property colorMax from MinMaxGradient
		Write(value.colorMax);
		
		// Property colorMin from MinMaxGradient
		Write(value.colorMin);
		
		// Property color from MinMaxGradient
		Write(value.color);
		
		// Property gradient from MinMaxGradient
		Write(value.gradient);
	}


	public void Write(ParticleSystemGradientMode value)
	{
		Stream.WriteInt32((int)value);
	}


	public void Write(ParticleSystemSimulationSpace value)
	{
		Stream.WriteInt32((int)value);
	}


	public void Write(ParticleSystemScalingMode value)
	{
		Stream.WriteInt32((int)value);
	}


	public void Write(ParticleSystemEmitterVelocityMode value)
	{
		Stream.WriteInt32((int)value);
	}


	public void Write(ParticleSystemStopAction value)
	{
		Stream.WriteInt32((int)value);
	}


	public void Write(ParticleSystem.EmissionModule value)
	{
		// Special case for enabled. Skip if disabled.
		Stream.WriteBoolean(value.enabled);
		if(value.enabled == false) return;
		
		// Property rateOverTime from EmissionModule
		Write(value.rateOverTime);
		
		// Property rateOverTimeMultiplier from EmissionModule
		Stream.WriteSingle(value.rateOverTimeMultiplier);
		
		// Property rateOverDistance from EmissionModule
		Write(value.rateOverDistance);
		
		// Property rateOverDistanceMultiplier from EmissionModule
		Stream.WriteSingle(value.rateOverDistanceMultiplier);
		
		// Property burstCount from EmissionModule
		Stream.WriteInt32(value.burstCount);
		
		// Property type from EmissionModule
		
		// Property rate from EmissionModule
		
		// Property rateMultiplier from EmissionModule
	}


	public void Write(ParticleSystem.ShapeModule value)
	{
		// Special case for enabled. Skip if disabled.
		Stream.WriteBoolean(value.enabled);
		if(value.enabled == false) return;
		
		// Property shapeType from ShapeModule
		Write(value.shapeType);
		
		// Property randomDirectionAmount from ShapeModule
		Stream.WriteSingle(value.randomDirectionAmount);
		
		// Property sphericalDirectionAmount from ShapeModule
		Stream.WriteSingle(value.sphericalDirectionAmount);
		
		// Property randomPositionAmount from ShapeModule
		Stream.WriteSingle(value.randomPositionAmount);
		
		// Property alignToDirection from ShapeModule
		Stream.WriteBoolean(value.alignToDirection);
		
		// Property radius from ShapeModule
		Stream.WriteSingle(value.radius);
		
		// Property radiusMode from ShapeModule
		Write(value.radiusMode);
		
		// Property radiusSpread from ShapeModule
		Stream.WriteSingle(value.radiusSpread);
		
		// Property radiusSpeed from ShapeModule
		Write(value.radiusSpeed);
		
		// Property radiusSpeedMultiplier from ShapeModule
		Stream.WriteSingle(value.radiusSpeedMultiplier);
		
		// Property radiusThickness from ShapeModule
		Stream.WriteSingle(value.radiusThickness);
		
		// Property angle from ShapeModule
		Stream.WriteSingle(value.angle);
		
		// Property length from ShapeModule
		Stream.WriteSingle(value.length);
		
		// Property box from ShapeModule
		
		// Property boxThickness from ShapeModule
		Stream.WriteVector3(value.boxThickness);
		
		// Property meshShapeType from ShapeModule
		Write(value.meshShapeType);
		
		// Property mesh from ShapeModule
		
		// Property meshRenderer from ShapeModule
		
		// Property skinnedMeshRenderer from ShapeModule
		
		// Property useMeshMaterialIndex from ShapeModule
		Stream.WriteBoolean(value.useMeshMaterialIndex);
		
		// Property meshMaterialIndex from ShapeModule
		Stream.WriteInt32(value.meshMaterialIndex);
		
		// Property useMeshColors from ShapeModule
		Stream.WriteBoolean(value.useMeshColors);
		
		// Property normalOffset from ShapeModule
		Stream.WriteSingle(value.normalOffset);
		
		// Property meshScale from ShapeModule
		
		// Property arc from ShapeModule
		Stream.WriteSingle(value.arc);
		
		// Property arcMode from ShapeModule
		Write(value.arcMode);
		
		// Property arcSpread from ShapeModule
		Stream.WriteSingle(value.arcSpread);
		
		// Property arcSpeed from ShapeModule
		Write(value.arcSpeed);
		
		// Property arcSpeedMultiplier from ShapeModule
		Stream.WriteSingle(value.arcSpeedMultiplier);
		
		// Property donutRadius from ShapeModule
		Stream.WriteSingle(value.donutRadius);
		
		// Property position from ShapeModule
		Stream.WriteVector3(value.position);
		
		// Property rotation from ShapeModule
		Stream.WriteVector3(value.rotation);
		
		// Property scale from ShapeModule
		Stream.WriteVector3(value.scale);
		
		// Property randomDirection from ShapeModule
	}


	public void Write(ParticleSystemShapeType value)
	{
		Stream.WriteInt32((int)value);
	}


	public void Write(ParticleSystemShapeMultiModeValue value)
	{
		Stream.WriteInt32((int)value);
	}


	public void Write(ParticleSystemMeshShapeType value)
	{
		Stream.WriteInt32((int)value);
	}


	public void Write(ParticleSystem.VelocityOverLifetimeModule value)
	{
		// Special case for enabled. Skip if disabled.
		Stream.WriteBoolean(value.enabled);
		if(value.enabled == false) return;
		
		// Property x from VelocityOverLifetimeModule
		Write(value.x);
		
		// Property y from VelocityOverLifetimeModule
		Write(value.y);
		
		// Property z from VelocityOverLifetimeModule
		Write(value.z);
		
		// Property xMultiplier from VelocityOverLifetimeModule
		Stream.WriteSingle(value.xMultiplier);
		
		// Property yMultiplier from VelocityOverLifetimeModule
		Stream.WriteSingle(value.yMultiplier);
		
		// Property zMultiplier from VelocityOverLifetimeModule
		Stream.WriteSingle(value.zMultiplier);
		
		// Property space from VelocityOverLifetimeModule
		Write(value.space);
	}


	public void Write(ParticleSystem.LimitVelocityOverLifetimeModule value)
	{
		// Special case for enabled. Skip if disabled.
		Stream.WriteBoolean(value.enabled);
		if(value.enabled == false) return;
		
		// Property limitX from LimitVelocityOverLifetimeModule
		Write(value.limitX);
		
		// Property limitXMultiplier from LimitVelocityOverLifetimeModule
		Stream.WriteSingle(value.limitXMultiplier);
		
		// Property limitY from LimitVelocityOverLifetimeModule
		Write(value.limitY);
		
		// Property limitYMultiplier from LimitVelocityOverLifetimeModule
		Stream.WriteSingle(value.limitYMultiplier);
		
		// Property limitZ from LimitVelocityOverLifetimeModule
		Write(value.limitZ);
		
		// Property limitZMultiplier from LimitVelocityOverLifetimeModule
		Stream.WriteSingle(value.limitZMultiplier);
		
		// Property limit from LimitVelocityOverLifetimeModule
		Write(value.limit);
		
		// Property limitMultiplier from LimitVelocityOverLifetimeModule
		Stream.WriteSingle(value.limitMultiplier);
		
		// Property dampen from LimitVelocityOverLifetimeModule
		Stream.WriteSingle(value.dampen);
		
		// Property separateAxes from LimitVelocityOverLifetimeModule
		Stream.WriteBoolean(value.separateAxes);
		
		// Property space from LimitVelocityOverLifetimeModule
		Write(value.space);
		
		// Property drag from LimitVelocityOverLifetimeModule
		Write(value.drag);
		
		// Property dragMultiplier from LimitVelocityOverLifetimeModule
		Stream.WriteSingle(value.dragMultiplier);
		
		// Property multiplyDragByParticleSize from LimitVelocityOverLifetimeModule
		Stream.WriteBoolean(value.multiplyDragByParticleSize);
		
		// Property multiplyDragByParticleVelocity from LimitVelocityOverLifetimeModule
		Stream.WriteBoolean(value.multiplyDragByParticleVelocity);
	}


	public void Write(ParticleSystem.InheritVelocityModule value)
	{
		// Special case for enabled. Skip if disabled.
		Stream.WriteBoolean(value.enabled);
		if(value.enabled == false) return;
		
		// Property mode from InheritVelocityModule
		Write(value.mode);
		
		// Property curve from InheritVelocityModule
		Write(value.curve);
		
		// Property curveMultiplier from InheritVelocityModule
		Stream.WriteSingle(value.curveMultiplier);
	}


	public void Write(ParticleSystemInheritVelocityMode value)
	{
		Stream.WriteInt32((int)value);
	}


	public void Write(ParticleSystem.ForceOverLifetimeModule value)
	{
		// Special case for enabled. Skip if disabled.
		Stream.WriteBoolean(value.enabled);
		if(value.enabled == false) return;
		
		// Property x from ForceOverLifetimeModule
		Write(value.x);
		
		// Property y from ForceOverLifetimeModule
		Write(value.y);
		
		// Property z from ForceOverLifetimeModule
		Write(value.z);
		
		// Property xMultiplier from ForceOverLifetimeModule
		Stream.WriteSingle(value.xMultiplier);
		
		// Property yMultiplier from ForceOverLifetimeModule
		Stream.WriteSingle(value.yMultiplier);
		
		// Property zMultiplier from ForceOverLifetimeModule
		Stream.WriteSingle(value.zMultiplier);
		
		// Property space from ForceOverLifetimeModule
		Write(value.space);
		
		// Property randomized from ForceOverLifetimeModule
		Stream.WriteBoolean(value.randomized);
	}


	public void Write(ParticleSystem.ColorOverLifetimeModule value)
	{
		// Special case for enabled. Skip if disabled.
		Stream.WriteBoolean(value.enabled);
		if(value.enabled == false) return;
		
		// Property color from ColorOverLifetimeModule
		Write(value.color);
	}


	public void Write(ParticleSystem.ColorBySpeedModule value)
	{
		// Special case for enabled. Skip if disabled.
		Stream.WriteBoolean(value.enabled);
		if(value.enabled == false) return;
		
		// Property color from ColorBySpeedModule
		Write(value.color);
		
		// Property range from ColorBySpeedModule
		Stream.WriteVector2(value.range);
	}


	public void Write(ParticleSystem.SizeOverLifetimeModule value)
	{
		// Special case for enabled. Skip if disabled.
		Stream.WriteBoolean(value.enabled);
		if(value.enabled == false) return;
		
		// Property size from SizeOverLifetimeModule
		Write(value.size);
		
		// Property sizeMultiplier from SizeOverLifetimeModule
		Stream.WriteSingle(value.sizeMultiplier);
		
		// Property x from SizeOverLifetimeModule
		Write(value.x);
		
		// Property xMultiplier from SizeOverLifetimeModule
		Stream.WriteSingle(value.xMultiplier);
		
		// Property y from SizeOverLifetimeModule
		Write(value.y);
		
		// Property yMultiplier from SizeOverLifetimeModule
		Stream.WriteSingle(value.yMultiplier);
		
		// Property z from SizeOverLifetimeModule
		Write(value.z);
		
		// Property zMultiplier from SizeOverLifetimeModule
		Stream.WriteSingle(value.zMultiplier);
		
		// Property separateAxes from SizeOverLifetimeModule
		Stream.WriteBoolean(value.separateAxes);
	}


	public void Write(ParticleSystem.SizeBySpeedModule value)
	{
		// Special case for enabled. Skip if disabled.
		Stream.WriteBoolean(value.enabled);
		if(value.enabled == false) return;
		
		// Property size from SizeBySpeedModule
		Write(value.size);
		
		// Property sizeMultiplier from SizeBySpeedModule
		Stream.WriteSingle(value.sizeMultiplier);
		
		// Property x from SizeBySpeedModule
		Write(value.x);
		
		// Property xMultiplier from SizeBySpeedModule
		Stream.WriteSingle(value.xMultiplier);
		
		// Property y from SizeBySpeedModule
		Write(value.y);
		
		// Property yMultiplier from SizeBySpeedModule
		Stream.WriteSingle(value.yMultiplier);
		
		// Property z from SizeBySpeedModule
		Write(value.z);
		
		// Property zMultiplier from SizeBySpeedModule
		Stream.WriteSingle(value.zMultiplier);
		
		// Property separateAxes from SizeBySpeedModule
		Stream.WriteBoolean(value.separateAxes);
		
		// Property range from SizeBySpeedModule
		Stream.WriteVector2(value.range);
	}


	public void Write(ParticleSystem.RotationOverLifetimeModule value)
	{
		// Special case for enabled. Skip if disabled.
		Stream.WriteBoolean(value.enabled);
		if(value.enabled == false) return;
		
		// Property x from RotationOverLifetimeModule
		Write(value.x);
		
		// Property xMultiplier from RotationOverLifetimeModule
		Stream.WriteSingle(value.xMultiplier);
		
		// Property y from RotationOverLifetimeModule
		Write(value.y);
		
		// Property yMultiplier from RotationOverLifetimeModule
		Stream.WriteSingle(value.yMultiplier);
		
		// Property z from RotationOverLifetimeModule
		Write(value.z);
		
		// Property zMultiplier from RotationOverLifetimeModule
		Stream.WriteSingle(value.zMultiplier);
		
		// Property separateAxes from RotationOverLifetimeModule
		Stream.WriteBoolean(value.separateAxes);
	}


	public void Write(ParticleSystem.RotationBySpeedModule value)
	{
		// Special case for enabled. Skip if disabled.
		Stream.WriteBoolean(value.enabled);
		if(value.enabled == false) return;
		
		// Property x from RotationBySpeedModule
		Write(value.x);
		
		// Property xMultiplier from RotationBySpeedModule
		Stream.WriteSingle(value.xMultiplier);
		
		// Property y from RotationBySpeedModule
		Write(value.y);
		
		// Property yMultiplier from RotationBySpeedModule
		Stream.WriteSingle(value.yMultiplier);
		
		// Property z from RotationBySpeedModule
		Write(value.z);
		
		// Property zMultiplier from RotationBySpeedModule
		Stream.WriteSingle(value.zMultiplier);
		
		// Property separateAxes from RotationBySpeedModule
		Stream.WriteBoolean(value.separateAxes);
		
		// Property range from RotationBySpeedModule
		Stream.WriteVector2(value.range);
	}


	public void Write(ParticleSystem.ExternalForcesModule value)
	{
		// Special case for enabled. Skip if disabled.
		Stream.WriteBoolean(value.enabled);
		if(value.enabled == false) return;
		
		// Property multiplier from ExternalForcesModule
		Stream.WriteSingle(value.multiplier);
	}


	public void Write(ParticleSystem.NoiseModule value)
	{
		// Special case for enabled. Skip if disabled.
		Stream.WriteBoolean(value.enabled);
		if(value.enabled == false) return;
		
		// Property separateAxes from NoiseModule
		Stream.WriteBoolean(value.separateAxes);
		
		// Property strength from NoiseModule
		Write(value.strength);
		
		// Property strengthMultiplier from NoiseModule
		Stream.WriteSingle(value.strengthMultiplier);
		
		// Property strengthX from NoiseModule
		Write(value.strengthX);
		
		// Property strengthXMultiplier from NoiseModule
		Stream.WriteSingle(value.strengthXMultiplier);
		
		// Property strengthY from NoiseModule
		Write(value.strengthY);
		
		// Property strengthYMultiplier from NoiseModule
		Stream.WriteSingle(value.strengthYMultiplier);
		
		// Property strengthZ from NoiseModule
		Write(value.strengthZ);
		
		// Property strengthZMultiplier from NoiseModule
		Stream.WriteSingle(value.strengthZMultiplier);
		
		// Property frequency from NoiseModule
		Stream.WriteSingle(value.frequency);
		
		// Property damping from NoiseModule
		Stream.WriteBoolean(value.damping);
		
		// Property octaveCount from NoiseModule
		Stream.WriteInt32(value.octaveCount);
		
		// Property octaveMultiplier from NoiseModule
		Stream.WriteSingle(value.octaveMultiplier);
		
		// Property octaveScale from NoiseModule
		Stream.WriteSingle(value.octaveScale);
		
		// Property quality from NoiseModule
		Write(value.quality);
		
		// Property scrollSpeed from NoiseModule
		Write(value.scrollSpeed);
		
		// Property scrollSpeedMultiplier from NoiseModule
		Stream.WriteSingle(value.scrollSpeedMultiplier);
		
		// Property remapEnabled from NoiseModule
		Stream.WriteBoolean(value.remapEnabled);
		
		// Property remap from NoiseModule
		Write(value.remap);
		
		// Property remapMultiplier from NoiseModule
		Stream.WriteSingle(value.remapMultiplier);
		
		// Property remapX from NoiseModule
		Write(value.remapX);
		
		// Property remapXMultiplier from NoiseModule
		Stream.WriteSingle(value.remapXMultiplier);
		
		// Property remapY from NoiseModule
		Write(value.remapY);
		
		// Property remapYMultiplier from NoiseModule
		Stream.WriteSingle(value.remapYMultiplier);
		
		// Property remapZ from NoiseModule
		Write(value.remapZ);
		
		// Property remapZMultiplier from NoiseModule
		Stream.WriteSingle(value.remapZMultiplier);
		
		// Property positionAmount from NoiseModule
		Write(value.positionAmount);
		
		// Property rotationAmount from NoiseModule
		Write(value.rotationAmount);
		
		// Property sizeAmount from NoiseModule
		Write(value.sizeAmount);
	}


	public void Write(ParticleSystemNoiseQuality value)
	{
		Stream.WriteInt32((int)value);
	}


	public void Write(ParticleSystem.CollisionModule value)
	{
		// Special case for enabled. Skip if disabled.
		Stream.WriteBoolean(value.enabled);
		if(value.enabled == false) return;
		
		// Property type from CollisionModule
		Write(value.type);
		
		// Property mode from CollisionModule
		Write(value.mode);
		
		// Property dampen from CollisionModule
		Write(value.dampen);
		
		// Property dampenMultiplier from CollisionModule
		Stream.WriteSingle(value.dampenMultiplier);
		
		// Property bounce from CollisionModule
		Write(value.bounce);
		
		// Property bounceMultiplier from CollisionModule
		Stream.WriteSingle(value.bounceMultiplier);
		
		// Property lifetimeLoss from CollisionModule
		Write(value.lifetimeLoss);
		
		// Property lifetimeLossMultiplier from CollisionModule
		Stream.WriteSingle(value.lifetimeLossMultiplier);
		
		// Property minKillSpeed from CollisionModule
		Stream.WriteSingle(value.minKillSpeed);
		
		// Property maxKillSpeed from CollisionModule
		Stream.WriteSingle(value.maxKillSpeed);
		
		// Property collidesWith from CollisionModule
		Write(value.collidesWith);
		
		// Property enableDynamicColliders from CollisionModule
		Stream.WriteBoolean(value.enableDynamicColliders);
		
		// Property enableInteriorCollisions from CollisionModule
		
		// Property maxCollisionShapes from CollisionModule
		Stream.WriteInt32(value.maxCollisionShapes);
		
		// Property quality from CollisionModule
		Write(value.quality);
		
		// Property voxelSize from CollisionModule
		Stream.WriteSingle(value.voxelSize);
		
		// Property radiusScale from CollisionModule
		Stream.WriteSingle(value.radiusScale);
		
		// Property sendCollisionMessages from CollisionModule
		Stream.WriteBoolean(value.sendCollisionMessages);
		
		// Property colliderForce from CollisionModule
		Stream.WriteSingle(value.colliderForce);
		
		// Property multiplyColliderForceByCollisionAngle from CollisionModule
		Stream.WriteBoolean(value.multiplyColliderForceByCollisionAngle);
		
		// Property multiplyColliderForceByParticleSpeed from CollisionModule
		Stream.WriteBoolean(value.multiplyColliderForceByParticleSpeed);
		
		// Property multiplyColliderForceByParticleSize from CollisionModule
		Stream.WriteBoolean(value.multiplyColliderForceByParticleSize);
		
		// Property maxPlaneCount from CollisionModule
	}


	public void Write(ParticleSystemCollisionType value)
	{
		Stream.WriteInt32((int)value);
	}


	public void Write(ParticleSystemCollisionMode value)
	{
		Stream.WriteInt32((int)value);
	}


	public void Write(LayerMask value)
	{
		
		// Property value from LayerMask
		Stream.WriteInt32(value.value);
	}


	public void Write(ParticleSystemCollisionQuality value)
	{
		Stream.WriteInt32((int)value);
	}


	public void Write(ParticleSystem.TriggerModule value)
	{
		// Special case for enabled. Skip if disabled.
		Stream.WriteBoolean(value.enabled);
		if(value.enabled == false) return;
		
		// Property inside from TriggerModule
		Write(value.inside);
		
		// Property outside from TriggerModule
		Write(value.outside);
		
		// Property enter from TriggerModule
		Write(value.enter);
		
		// Property exit from TriggerModule
		Write(value.exit);
		
		// Property radiusScale from TriggerModule
		Stream.WriteSingle(value.radiusScale);
		
		// Property maxColliderCount from TriggerModule
	}


	public void Write(ParticleSystemOverlapAction value)
	{
		Stream.WriteInt32((int)value);
	}


	public void Write(ParticleSystem.SubEmittersModule value)
	{
		// Special case for enabled. Skip if disabled.
		Stream.WriteBoolean(value.enabled);
		if(value.enabled == false) return;
		
		// Property subEmittersCount from SubEmittersModule
		
		// Property birth0 from SubEmittersModule
		
		// Property birth1 from SubEmittersModule
		
		// Property collision0 from SubEmittersModule
		
		// Property collision1 from SubEmittersModule
		
		// Property death0 from SubEmittersModule
		
		// Property death1 from SubEmittersModule
	}


	public void Write(ParticleSystem.TextureSheetAnimationModule value)
	{
		// Special case for enabled. Skip if disabled.
		Stream.WriteBoolean(value.enabled);
		if(value.enabled == false) return;
		
		// Property mode from TextureSheetAnimationModule
		Write(value.mode);
		
		// Property numTilesX from TextureSheetAnimationModule
		Stream.WriteInt32(value.numTilesX);
		
		// Property numTilesY from TextureSheetAnimationModule
		Stream.WriteInt32(value.numTilesY);
		
		// Property animation from TextureSheetAnimationModule
		Write(value.animation);
		
		// Property useRandomRow from TextureSheetAnimationModule
		Stream.WriteBoolean(value.useRandomRow);
		
		// Property frameOverTime from TextureSheetAnimationModule
		Write(value.frameOverTime);
		
		// Property frameOverTimeMultiplier from TextureSheetAnimationModule
		Stream.WriteSingle(value.frameOverTimeMultiplier);
		
		// Property startFrame from TextureSheetAnimationModule
		Write(value.startFrame);
		
		// Property startFrameMultiplier from TextureSheetAnimationModule
		Stream.WriteSingle(value.startFrameMultiplier);
		
		// Property cycleCount from TextureSheetAnimationModule
		Stream.WriteInt32(value.cycleCount);
		
		// Property rowIndex from TextureSheetAnimationModule
		Stream.WriteInt32(value.rowIndex);
		
		// Property uvChannelMask from TextureSheetAnimationModule
		Write(value.uvChannelMask);
		
		// Property flipU from TextureSheetAnimationModule
		Stream.WriteSingle(value.flipU);
		
		// Property flipV from TextureSheetAnimationModule
		Stream.WriteSingle(value.flipV);
		
		// Property spriteCount from TextureSheetAnimationModule
	}


	public void Write(ParticleSystemAnimationMode value)
	{
		Stream.WriteInt32((int)value);
	}


	public void Write(ParticleSystemAnimationType value)
	{
		Stream.WriteInt32((int)value);
	}


	public void Write(UVChannelFlags value)
	{
		Stream.WriteInt32((int)value);
	}


	public void Write(ParticleSystem.LightsModule value)
	{
		// Special case for enabled. Skip if disabled.
		Stream.WriteBoolean(value.enabled);
		if(value.enabled == false) return;
		
		// Property ratio from LightsModule
		Stream.WriteSingle(value.ratio);
		
		// Property useRandomDistribution from LightsModule
		Stream.WriteBoolean(value.useRandomDistribution);
		
		// Property light from LightsModule
		
		// Property useParticleColor from LightsModule
		Stream.WriteBoolean(value.useParticleColor);
		
		// Property sizeAffectsRange from LightsModule
		Stream.WriteBoolean(value.sizeAffectsRange);
		
		// Property alphaAffectsIntensity from LightsModule
		Stream.WriteBoolean(value.alphaAffectsIntensity);
		
		// Property range from LightsModule
		Write(value.range);
		
		// Property rangeMultiplier from LightsModule
		Stream.WriteSingle(value.rangeMultiplier);
		
		// Property intensity from LightsModule
		Write(value.intensity);
		
		// Property intensityMultiplier from LightsModule
		Stream.WriteSingle(value.intensityMultiplier);
		
		// Property maxLights from LightsModule
		Stream.WriteInt32(value.maxLights);
	}


	public void Write(ParticleSystem.TrailModule value)
	{
		// Special case for enabled. Skip if disabled.
		Stream.WriteBoolean(value.enabled);
		if(value.enabled == false) return;
		
		// Property ratio from TrailModule
		Stream.WriteSingle(value.ratio);
		
		// Property lifetime from TrailModule
		Write(value.lifetime);
		
		// Property lifetimeMultiplier from TrailModule
		Stream.WriteSingle(value.lifetimeMultiplier);
		
		// Property minVertexDistance from TrailModule
		Stream.WriteSingle(value.minVertexDistance);
		
		// Property textureMode from TrailModule
		Write(value.textureMode);
		
		// Property worldSpace from TrailModule
		Stream.WriteBoolean(value.worldSpace);
		
		// Property dieWithParticles from TrailModule
		Stream.WriteBoolean(value.dieWithParticles);
		
		// Property sizeAffectsWidth from TrailModule
		Stream.WriteBoolean(value.sizeAffectsWidth);
		
		// Property sizeAffectsLifetime from TrailModule
		Stream.WriteBoolean(value.sizeAffectsLifetime);
		
		// Property inheritParticleColor from TrailModule
		Stream.WriteBoolean(value.inheritParticleColor);
		
		// Property colorOverLifetime from TrailModule
		Write(value.colorOverLifetime);
		
		// Property widthOverTrail from TrailModule
		Write(value.widthOverTrail);
		
		// Property widthOverTrailMultiplier from TrailModule
		Stream.WriteSingle(value.widthOverTrailMultiplier);
		
		// Property colorOverTrail from TrailModule
		Write(value.colorOverTrail);
		
		// Property generateLightingData from TrailModule
		Stream.WriteBoolean(value.generateLightingData);
	}


	public void Write(ParticleSystemTrailTextureMode value)
	{
		Stream.WriteInt32((int)value);
	}


	public void Write(ParticleSystem.CustomDataModule value)
	{
		// Special case for enabled. Skip if disabled.
		Stream.WriteBoolean(value.enabled);
		if(value.enabled == false) return;
	}

    /*
	public void Write(MeshTunnelAnimator value)
	{
		// Special case for enabled. Skip if disabled.
		Stream.WriteBoolean(value.enabled);
		if(value.enabled == false) return;
		
		// Property useGUILayout from MonoBehaviour
		
		// Property runInEditMode from MonoBehaviour
		
		// Property isActiveAndEnabled from Behaviour
		
		// Property transform from Component
		
		// Property gameObject from Component
		
		// Property tag from Component
		
		// Property rigidbody from Component
		
		// Property rigidbody2D from Component
		
		// Property camera from Component
		
		// Property light from Component
		
		// Property animation from Component
		
		// Property constantForce from Component
		
		// Property renderer from Component
		
		// Property audio from Component
		
		// Property guiText from Component
		
		// Property networkView from Component
		
		// Property guiElement from Component
		
		// Property guiTexture from Component
		
		// Property collider from Component
		
		// Property collider2D from Component
		
		// Property hingeJoint from Component
		
		// Property particleEmitter from Component
		
		// Property particleSystem from Component
		
		// Property name from Object
		
		// Property hideFlags from Object

		// Field GameObject

		// Field Int32
		Stream.WriteInt32(value.NumberToSpawn);

		// Field Boolean
		Stream.WriteBoolean(value.SpawnOnGrid);

		// Field Vector3Int
		Write(value.GridSize);

		// Field Boolean
		Stream.WriteBoolean(value.EnableGridMotionLock);

		// Field Vector3Int
		Write(value.LockBoxMin);

		// Field Vector3Int
		Write(value.LockBoxMax);

		// Field Vector3
		Stream.WriteVector3(value.GridSpacing);

		// Field Material

		// Field Boolean
		Stream.WriteBoolean(value.SpawnWithZeroTime);

		// Field Single
		Stream.WriteSingle(value.CycleTime);

		// Field Single
		Stream.WriteSingle(value.SpeedVariance);

		// Field Single
		Stream.WriteSingle(value.SpeedOffset);

		// Field AnimationCurve
		Write(value.Location);

		// Field Vector3
		Stream.WriteVector3(value.DirectionOfMotion);

		// Field AnimationCurve
		Write(value.Rotation);

		// Field Vector3
		Stream.WriteVector3(value.AxisOfRotation);

		// Field Single
		Stream.WriteSingle(value.RotationScale);

		// Field AnimationCurve
		Write(value.Scale);

		// Field Vector3
		Stream.WriteVector3(value.ScaleFactor);

		// Field Gradient
		Write(value.Color);
	}


	public void Write(SpawnDriftingObjects value)
	{
		// Special case for enabled. Skip if disabled.
		Stream.WriteBoolean(value.enabled);
		if(value.enabled == false) return;
		
		// Property useGUILayout from MonoBehaviour
		
		// Property runInEditMode from MonoBehaviour
		
		// Property isActiveAndEnabled from Behaviour
		
		// Property transform from Component
		
		// Property gameObject from Component
		
		// Property tag from Component
		
		// Property rigidbody from Component
		
		// Property rigidbody2D from Component
		
		// Property camera from Component
		
		// Property light from Component
		
		// Property animation from Component
		
		// Property constantForce from Component
		
		// Property renderer from Component
		
		// Property audio from Component
		
		// Property guiText from Component
		
		// Property networkView from Component
		
		// Property guiElement from Component
		
		// Property guiTexture from Component
		
		// Property collider from Component
		
		// Property collider2D from Component
		
		// Property hingeJoint from Component
		
		// Property particleEmitter from Component
		
		// Property particleSystem from Component
		
		// Property name from Object
		
		// Property hideFlags from Object

		// Field GameObject

		// Field Int32
		Stream.WriteInt32(value.SpawnCount);

		// Field Single
		Stream.WriteSingle(value.RadiusMin);

		// Field Single
		Stream.WriteSingle(value.RadiusMax);

		// Field Single
		Stream.WriteSingle(value.RandomScaleMin);

		// Field Single
		Stream.WriteSingle(value.RandomScaleMax);

		// Field Single
		Stream.WriteSingle(value.ItemSpinSpeedMin);

		// Field Single
		Stream.WriteSingle(value.ItemSpinSpeedMax);

		// Field Single
		Stream.WriteSingle(value.OverallSpinSpeedMin);

		// Field Single
		Stream.WriteSingle(value.OverallSpinSpeedMax);

		// Field List<GameObject>

		// Field List<Single>
		//Write(value.SpawnedObjectSpins);

		// Field Single
		Stream.WriteSingle(value.OverallSpinSpeed);
	}
        */

    public void Write(LevelScene value)
	{

		// Field String
		Stream.WriteString(value.name);

		// Field LevelObject
		Write(value.root);

		// Field Int32
		Stream.WriteInt32(value.skyboxId);

		// Field Vector3
		Stream.WriteVector3(value.sunDirection);

		// Field Vector3
		Stream.WriteVector3(value.previewPosition);

		// Field Quaternion
		Stream.WriteQuaternion(value.previewOrientation);
	}


	public void Write(LevelObject value)
	{

		// Field String
		Stream.WriteString(value.name);

		// Field Vector3
		Stream.WriteVector3(value.position);

		// Field Quaternion
		Stream.WriteQuaternion(value.rotation);

		// Field Vector3
		Stream.WriteVector3(value.scale);

		// Field LevelMesh
		Write(value.mesh);

		// Field Int32
		Stream.WriteInt32(value.LargestChildVertexCount);

		// Field String
		Stream.WriteString(value.prefabItem);

		// Field SimpleBuffer
		Write(value.serializedContent);

		// Field Dictionary<String,Object>
		Write(value.properties);

		// Field List<LevelObject>
		Write(value.children);
	}


	public void Write(LevelMesh value)
	{
		
		// Property HasNormal from LevelMesh
		
		// Property HasUV1 from LevelMesh
		
		// Property HasUV2 from LevelMesh
		
		// Property IsStatic from LevelMesh

		// Field Int32
		Stream.WriteInt32((int)value.Flags);

		// Field Int32
		Stream.WriteInt32(value.vertexCount);

		// Field SimpleBuffer
		Write(value.verts);

		// Field Int32
		Stream.WriteInt32(value.indexCount);

		// Field SimpleBuffer
		Write(value.indices);

		// Field List<LevelSubMesh>
		Write(value.subMeshes);

		// Field List<String>
		Write(value.materials);

		// Field Int32
		Stream.WriteInt32(value.lightmapIndex);

		// Field Vector4
		Stream.WriteVector4(value.lightmapScaleOffset);

        Stream.WriteVector3(value.bounds.center);
        Stream.WriteVector3(value.bounds.size);
    }


	public void Write(LevelSubMesh value)
	{

		// Field Int32
		Stream.WriteInt32(value.start);

		// Field Int32
		Stream.WriteInt32(value.count);

		// Field String
		Stream.WriteString(value.material);
	}


	public void Read(ref ParticleSystem value)
	{
		
		// Property startDelay from ParticleSystem
		
		// Property isPlaying from ParticleSystem
		
		// Property isEmitting from ParticleSystem
		
		// Property isStopped from ParticleSystem
		
		// Property isPaused from ParticleSystem
		
		// Property loop from ParticleSystem
		
		// Property playOnAwake from ParticleSystem
		
		// Property time from ParticleSystem
		Single x_time;
		Stream.ReadSingle(out x_time);
		value.time = x_time;
		
		// Property duration from ParticleSystem
		
		// Property playbackSpeed from ParticleSystem
		
		// Property particleCount from ParticleSystem
		
		// Property enableEmission from ParticleSystem
		
		// Property emissionRate from ParticleSystem
		
		// Property startSpeed from ParticleSystem
		
		// Property startSize from ParticleSystem
		
		// Property startColor from ParticleSystem
		
		// Property startRotation from ParticleSystem
		
		// Property startRotation3D from ParticleSystem
		
		// Property startLifetime from ParticleSystem
		
		// Property gravityModifier from ParticleSystem
		
		// Property maxParticles from ParticleSystem
		
		// Property simulationSpace from ParticleSystem
		
		// Property scalingMode from ParticleSystem
		
		// Property randomSeed from ParticleSystem
		UInt32 x_randomSeed;
		Stream.ReadUInt32(out x_randomSeed);
		value.randomSeed = x_randomSeed;
		
		// Property useAutoRandomSeed from ParticleSystem
		Boolean x_useAutoRandomSeed;
		Stream.ReadBoolean(out x_useAutoRandomSeed);
		value.useAutoRandomSeed = x_useAutoRandomSeed;
		
		// Property main from ParticleSystem
		ParticleSystem.MainModule x_main = value.main;
		Read(ref x_main);
		
		// Property emission from ParticleSystem
		ParticleSystem.EmissionModule x_emission = value.emission;
		Read(ref x_emission);
		
		// Property shape from ParticleSystem
		ParticleSystem.ShapeModule x_shape = value.shape;
		Read(ref x_shape);
		
		// Property velocityOverLifetime from ParticleSystem
		ParticleSystem.VelocityOverLifetimeModule x_velocityOverLifetime = value.velocityOverLifetime;
		Read(ref x_velocityOverLifetime);
		
		// Property limitVelocityOverLifetime from ParticleSystem
		ParticleSystem.LimitVelocityOverLifetimeModule x_limitVelocityOverLifetime = value.limitVelocityOverLifetime;
		Read(ref x_limitVelocityOverLifetime);
		
		// Property inheritVelocity from ParticleSystem
		ParticleSystem.InheritVelocityModule x_inheritVelocity = value.inheritVelocity;
		Read(ref x_inheritVelocity);
		
		// Property forceOverLifetime from ParticleSystem
		ParticleSystem.ForceOverLifetimeModule x_forceOverLifetime = value.forceOverLifetime;
		Read(ref x_forceOverLifetime);
		
		// Property colorOverLifetime from ParticleSystem
		ParticleSystem.ColorOverLifetimeModule x_colorOverLifetime = value.colorOverLifetime;
		Read(ref x_colorOverLifetime);
		
		// Property colorBySpeed from ParticleSystem
		ParticleSystem.ColorBySpeedModule x_colorBySpeed = value.colorBySpeed;
		Read(ref x_colorBySpeed);
		
		// Property sizeOverLifetime from ParticleSystem
		ParticleSystem.SizeOverLifetimeModule x_sizeOverLifetime = value.sizeOverLifetime;
		Read(ref x_sizeOverLifetime);
		
		// Property sizeBySpeed from ParticleSystem
		ParticleSystem.SizeBySpeedModule x_sizeBySpeed = value.sizeBySpeed;
		Read(ref x_sizeBySpeed);
		
		// Property rotationOverLifetime from ParticleSystem
		ParticleSystem.RotationOverLifetimeModule x_rotationOverLifetime = value.rotationOverLifetime;
		Read(ref x_rotationOverLifetime);
		
		// Property rotationBySpeed from ParticleSystem
		ParticleSystem.RotationBySpeedModule x_rotationBySpeed = value.rotationBySpeed;
		Read(ref x_rotationBySpeed);
		
		// Property externalForces from ParticleSystem
		ParticleSystem.ExternalForcesModule x_externalForces = value.externalForces;
		Read(ref x_externalForces);
		
		// Property noise from ParticleSystem
		ParticleSystem.NoiseModule x_noise = value.noise;
		Read(ref x_noise);
		
		// Property collision from ParticleSystem
		ParticleSystem.CollisionModule x_collision = value.collision;
		Read(ref x_collision);
		
		// Property trigger from ParticleSystem
		ParticleSystem.TriggerModule x_trigger = value.trigger;
		Read(ref x_trigger);
		
		// Property subEmitters from ParticleSystem
		ParticleSystem.SubEmittersModule x_subEmitters = value.subEmitters;
		Read(ref x_subEmitters);
		
		// Property textureSheetAnimation from ParticleSystem
		ParticleSystem.TextureSheetAnimationModule x_textureSheetAnimation = value.textureSheetAnimation;
		Read(ref x_textureSheetAnimation);
		
		// Property lights from ParticleSystem
		ParticleSystem.LightsModule x_lights = value.lights;
		Read(ref x_lights);
		
		// Property trails from ParticleSystem
		ParticleSystem.TrailModule x_trails = value.trails;
		Read(ref x_trails);
		
		// Property customData from ParticleSystem
		ParticleSystem.CustomDataModule x_customData = value.customData;
		Read(ref x_customData);
		
		// Property safeCollisionEventSize from ParticleSystem
		
		// Property transform from Component
		
		// Property gameObject from Component
		
		// Property tag from Component
		
		// Property rigidbody from Component
		
		// Property rigidbody2D from Component
		
		// Property camera from Component
		
		// Property light from Component
		
		// Property animation from Component
		
		// Property constantForce from Component
		
		// Property renderer from Component
		
		// Property audio from Component
		
		// Property guiText from Component
		
		// Property networkView from Component
		
		// Property guiElement from Component
		
		// Property guiTexture from Component
		
		// Property collider from Component
		
		// Property collider2D from Component
		
		// Property hingeJoint from Component
		
		// Property particleEmitter from Component
		
		// Property particleSystem from Component
		
		// Property name from Object
		
		// Property hideFlags from Object
	}


	public void Read(ref ParticleSystem.MainModule value)
	{
		
		// Property duration from MainModule
		Single x_duration;
		Stream.ReadSingle(out x_duration);
		value.duration = x_duration;
		
		// Property loop from MainModule
		Boolean x_loop;
		Stream.ReadBoolean(out x_loop);
		value.loop = x_loop;
		
		// Property prewarm from MainModule
		Boolean x_prewarm;
		Stream.ReadBoolean(out x_prewarm);
		value.prewarm = x_prewarm;
		
		// Property startDelay from MainModule
		ParticleSystem.MinMaxCurve x_startDelay = value.startDelay;
		Read(ref x_startDelay);
		value.startDelay = x_startDelay;
		
		// Property startDelayMultiplier from MainModule
		Single x_startDelayMultiplier;
		Stream.ReadSingle(out x_startDelayMultiplier);
		value.startDelayMultiplier = x_startDelayMultiplier;
		
		// Property startLifetime from MainModule
		ParticleSystem.MinMaxCurve x_startLifetime = value.startLifetime;
		Read(ref x_startLifetime);
		value.startLifetime = x_startLifetime;
		
		// Property startLifetimeMultiplier from MainModule
		Single x_startLifetimeMultiplier;
		Stream.ReadSingle(out x_startLifetimeMultiplier);
		value.startLifetimeMultiplier = x_startLifetimeMultiplier;
		
		// Property startSpeed from MainModule
		ParticleSystem.MinMaxCurve x_startSpeed = value.startSpeed;
		Read(ref x_startSpeed);
		value.startSpeed = x_startSpeed;
		
		// Property startSpeedMultiplier from MainModule
		Single x_startSpeedMultiplier;
		Stream.ReadSingle(out x_startSpeedMultiplier);
		value.startSpeedMultiplier = x_startSpeedMultiplier;
		
		// Property startSize3D from MainModule
		Boolean x_startSize3D;
		Stream.ReadBoolean(out x_startSize3D);
		value.startSize3D = x_startSize3D;
		
		// Property startSize from MainModule
		ParticleSystem.MinMaxCurve x_startSize = value.startSize;
		Read(ref x_startSize);
		value.startSize = x_startSize;
		
		// Property startSizeMultiplier from MainModule
		Single x_startSizeMultiplier;
		Stream.ReadSingle(out x_startSizeMultiplier);
		value.startSizeMultiplier = x_startSizeMultiplier;
		
		// Property startSizeX from MainModule
		ParticleSystem.MinMaxCurve x_startSizeX = value.startSizeX;
		Read(ref x_startSizeX);
		value.startSizeX = x_startSizeX;
		
		// Property startSizeXMultiplier from MainModule
		Single x_startSizeXMultiplier;
		Stream.ReadSingle(out x_startSizeXMultiplier);
		value.startSizeXMultiplier = x_startSizeXMultiplier;
		
		// Property startSizeY from MainModule
		ParticleSystem.MinMaxCurve x_startSizeY = value.startSizeY;
		Read(ref x_startSizeY);
		value.startSizeY = x_startSizeY;
		
		// Property startSizeYMultiplier from MainModule
		Single x_startSizeYMultiplier;
		Stream.ReadSingle(out x_startSizeYMultiplier);
		value.startSizeYMultiplier = x_startSizeYMultiplier;
		
		// Property startSizeZ from MainModule
		ParticleSystem.MinMaxCurve x_startSizeZ = value.startSizeZ;
		Read(ref x_startSizeZ);
		value.startSizeZ = x_startSizeZ;
		
		// Property startSizeZMultiplier from MainModule
		Single x_startSizeZMultiplier;
		Stream.ReadSingle(out x_startSizeZMultiplier);
		value.startSizeZMultiplier = x_startSizeZMultiplier;
		
		// Property startRotation3D from MainModule
		Boolean x_startRotation3D;
		Stream.ReadBoolean(out x_startRotation3D);
		value.startRotation3D = x_startRotation3D;
		
		// Property startRotation from MainModule
		ParticleSystem.MinMaxCurve x_startRotation = value.startRotation;
		Read(ref x_startRotation);
		value.startRotation = x_startRotation;
		
		// Property startRotationMultiplier from MainModule
		Single x_startRotationMultiplier;
		Stream.ReadSingle(out x_startRotationMultiplier);
		value.startRotationMultiplier = x_startRotationMultiplier;
		
		// Property startRotationX from MainModule
		ParticleSystem.MinMaxCurve x_startRotationX = value.startRotationX;
		Read(ref x_startRotationX);
		value.startRotationX = x_startRotationX;
		
		// Property startRotationXMultiplier from MainModule
		Single x_startRotationXMultiplier;
		Stream.ReadSingle(out x_startRotationXMultiplier);
		value.startRotationXMultiplier = x_startRotationXMultiplier;
		
		// Property startRotationY from MainModule
		ParticleSystem.MinMaxCurve x_startRotationY = value.startRotationY;
		Read(ref x_startRotationY);
		value.startRotationY = x_startRotationY;
		
		// Property startRotationYMultiplier from MainModule
		Single x_startRotationYMultiplier;
		Stream.ReadSingle(out x_startRotationYMultiplier);
		value.startRotationYMultiplier = x_startRotationYMultiplier;
		
		// Property startRotationZ from MainModule
		ParticleSystem.MinMaxCurve x_startRotationZ = value.startRotationZ;
		Read(ref x_startRotationZ);
		value.startRotationZ = x_startRotationZ;
		
		// Property startRotationZMultiplier from MainModule
		Single x_startRotationZMultiplier;
		Stream.ReadSingle(out x_startRotationZMultiplier);
		value.startRotationZMultiplier = x_startRotationZMultiplier;
		
		// Property randomizeRotationDirection from MainModule
		Single x_randomizeRotationDirection;
		Stream.ReadSingle(out x_randomizeRotationDirection);
		value.randomizeRotationDirection = x_randomizeRotationDirection;
		
		// Property startColor from MainModule
		ParticleSystem.MinMaxGradient x_startColor = value.startColor;
		Read(ref x_startColor);
		value.startColor = x_startColor;
		
		// Property gravityModifier from MainModule
		ParticleSystem.MinMaxCurve x_gravityModifier = value.gravityModifier;
		Read(ref x_gravityModifier);
		value.gravityModifier = x_gravityModifier;
		
		// Property gravityModifierMultiplier from MainModule
		Single x_gravityModifierMultiplier;
		Stream.ReadSingle(out x_gravityModifierMultiplier);
		value.gravityModifierMultiplier = x_gravityModifierMultiplier;
		
		// Property simulationSpace from MainModule
		ParticleSystemSimulationSpace x_simulationSpace = value.simulationSpace;
		Read(ref x_simulationSpace);
		value.simulationSpace = x_simulationSpace;
		
		// Property customSimulationSpace from MainModule
		
		// Property simulationSpeed from MainModule
		Single x_simulationSpeed;
		Stream.ReadSingle(out x_simulationSpeed);
		value.simulationSpeed = x_simulationSpeed;
		
		// Property useUnscaledTime from MainModule
		Boolean x_useUnscaledTime;
		Stream.ReadBoolean(out x_useUnscaledTime);
		value.useUnscaledTime = x_useUnscaledTime;
		
		// Property scalingMode from MainModule
		ParticleSystemScalingMode x_scalingMode = value.scalingMode;
		Read(ref x_scalingMode);
		value.scalingMode = x_scalingMode;
		
		// Property playOnAwake from MainModule
		Boolean x_playOnAwake;
		Stream.ReadBoolean(out x_playOnAwake);
		value.playOnAwake = x_playOnAwake;
		
		// Property maxParticles from MainModule
		Int32 x_maxParticles;
		Stream.ReadInt32(out x_maxParticles);
		value.maxParticles = x_maxParticles;
		
		// Property emitterVelocityMode from MainModule
		ParticleSystemEmitterVelocityMode x_emitterVelocityMode = value.emitterVelocityMode;
		Read(ref x_emitterVelocityMode);
		value.emitterVelocityMode = x_emitterVelocityMode;
		
		// Property stopAction from MainModule
		ParticleSystemStopAction x_stopAction = value.stopAction;
		Read(ref x_stopAction);
		value.stopAction = x_stopAction;
	}


	public void Read(ref ParticleSystem.MinMaxCurve value)
	{
		
		// Property mode from MinMaxCurve
		ParticleSystemCurveMode x_mode = value.mode;
		Read(ref x_mode);
		value.mode = x_mode;
		
		// Property curveScalar from MinMaxCurve
		
		// Property curveMultiplier from MinMaxCurve
		Single x_curveMultiplier;
		Stream.ReadSingle(out x_curveMultiplier);
		value.curveMultiplier = x_curveMultiplier;
		
		// Property curveMax from MinMaxCurve
		AnimationCurve x_curveMax = value.curveMax;
		Read(ref x_curveMax);
		value.curveMax = x_curveMax;
		
		// Property curveMin from MinMaxCurve
		AnimationCurve x_curveMin = value.curveMin;
		Read(ref x_curveMin);
		value.curveMin = x_curveMin;
		
		// Property constantMax from MinMaxCurve
		Single x_constantMax;
		Stream.ReadSingle(out x_constantMax);
		value.constantMax = x_constantMax;
		
		// Property constantMin from MinMaxCurve
		Single x_constantMin;
		Stream.ReadSingle(out x_constantMin);
		value.constantMin = x_constantMin;
		
		// Property constant from MinMaxCurve
		Single x_constant;
		Stream.ReadSingle(out x_constant);
		value.constant = x_constant;
		
		// Property curve from MinMaxCurve
		AnimationCurve x_curve = value.curve;
		Read(ref x_curve);
		value.curve = x_curve;
	}


	public void Read(ref ParticleSystemCurveMode value)
	{
		int temp;
		Stream.ReadInt32(out temp);
		value = (ParticleSystemCurveMode)temp;
	}


	public void Read(ref ParticleSystem.MinMaxGradient value)
	{
		
		// Property mode from MinMaxGradient
		ParticleSystemGradientMode x_mode = value.mode;
		Read(ref x_mode);
		value.mode = x_mode;
		
		// Property gradientMax from MinMaxGradient
		Gradient x_gradientMax = value.gradientMax;
		Read(ref x_gradientMax);
		value.gradientMax = x_gradientMax;
		
		// Property gradientMin from MinMaxGradient
		Gradient x_gradientMin = value.gradientMin;
		Read(ref x_gradientMin);
		value.gradientMin = x_gradientMin;
		
		// Property colorMax from MinMaxGradient
		Color x_colorMax = value.colorMax;
		Read(ref x_colorMax);
		value.colorMax = x_colorMax;
		
		// Property colorMin from MinMaxGradient
		Color x_colorMin = value.colorMin;
		Read(ref x_colorMin);
		value.colorMin = x_colorMin;
		
		// Property color from MinMaxGradient
		Color x_color = value.color;
		Read(ref x_color);
		value.color = x_color;
		
		// Property gradient from MinMaxGradient
		Gradient x_gradient = value.gradient;
		Read(ref x_gradient);
		value.gradient = x_gradient;
	}


	public void Read(ref ParticleSystemGradientMode value)
	{
		int temp;
		Stream.ReadInt32(out temp);
		value = (ParticleSystemGradientMode)temp;
	}


	public void Read(ref ParticleSystemSimulationSpace value)
	{
		int temp;
		Stream.ReadInt32(out temp);
		value = (ParticleSystemSimulationSpace)temp;
	}


	public void Read(ref ParticleSystemScalingMode value)
	{
		int temp;
		Stream.ReadInt32(out temp);
		value = (ParticleSystemScalingMode)temp;
	}


	public void Read(ref ParticleSystemEmitterVelocityMode value)
	{
		int temp;
		Stream.ReadInt32(out temp);
		value = (ParticleSystemEmitterVelocityMode)temp;
	}


	public void Read(ref ParticleSystemStopAction value)
	{
		int temp;
		Stream.ReadInt32(out temp);
		value = (ParticleSystemStopAction)temp;
	}


	public void Read(ref ParticleSystem.EmissionModule value)
	{
		// Special case for enabled. Skip if disabled.
		bool x_enabled;
		Stream.ReadBoolean(out x_enabled);
		value.enabled = x_enabled;
		if(x_enabled == false) return;
		
		// Property rateOverTime from EmissionModule
		ParticleSystem.MinMaxCurve x_rateOverTime = value.rateOverTime;
		Read(ref x_rateOverTime);
		value.rateOverTime = x_rateOverTime;
		
		// Property rateOverTimeMultiplier from EmissionModule
		Single x_rateOverTimeMultiplier;
		Stream.ReadSingle(out x_rateOverTimeMultiplier);
		value.rateOverTimeMultiplier = x_rateOverTimeMultiplier;
		
		// Property rateOverDistance from EmissionModule
		ParticleSystem.MinMaxCurve x_rateOverDistance = value.rateOverDistance;
		Read(ref x_rateOverDistance);
		value.rateOverDistance = x_rateOverDistance;
		
		// Property rateOverDistanceMultiplier from EmissionModule
		Single x_rateOverDistanceMultiplier;
		Stream.ReadSingle(out x_rateOverDistanceMultiplier);
		value.rateOverDistanceMultiplier = x_rateOverDistanceMultiplier;
		
		// Property burstCount from EmissionModule
		Int32 x_burstCount;
		Stream.ReadInt32(out x_burstCount);
		value.burstCount = x_burstCount;
		
		// Property type from EmissionModule
		
		// Property rate from EmissionModule
		
		// Property rateMultiplier from EmissionModule
	}


	public void Read(ref ParticleSystem.ShapeModule value)
	{
		// Special case for enabled. Skip if disabled.
		bool x_enabled;
		Stream.ReadBoolean(out x_enabled);
		value.enabled = x_enabled;
		if(x_enabled == false) return;
		
		// Property shapeType from ShapeModule
		ParticleSystemShapeType x_shapeType = value.shapeType;
		Read(ref x_shapeType);
		value.shapeType = x_shapeType;
		
		// Property randomDirectionAmount from ShapeModule
		Single x_randomDirectionAmount;
		Stream.ReadSingle(out x_randomDirectionAmount);
		value.randomDirectionAmount = x_randomDirectionAmount;
		
		// Property sphericalDirectionAmount from ShapeModule
		Single x_sphericalDirectionAmount;
		Stream.ReadSingle(out x_sphericalDirectionAmount);
		value.sphericalDirectionAmount = x_sphericalDirectionAmount;
		
		// Property randomPositionAmount from ShapeModule
		Single x_randomPositionAmount;
		Stream.ReadSingle(out x_randomPositionAmount);
		value.randomPositionAmount = x_randomPositionAmount;
		
		// Property alignToDirection from ShapeModule
		Boolean x_alignToDirection;
		Stream.ReadBoolean(out x_alignToDirection);
		value.alignToDirection = x_alignToDirection;
		
		// Property radius from ShapeModule
		Single x_radius;
		Stream.ReadSingle(out x_radius);
		value.radius = x_radius;
		
		// Property radiusMode from ShapeModule
		ParticleSystemShapeMultiModeValue x_radiusMode = value.radiusMode;
		Read(ref x_radiusMode);
		value.radiusMode = x_radiusMode;
		
		// Property radiusSpread from ShapeModule
		Single x_radiusSpread;
		Stream.ReadSingle(out x_radiusSpread);
		value.radiusSpread = x_radiusSpread;
		
		// Property radiusSpeed from ShapeModule
		ParticleSystem.MinMaxCurve x_radiusSpeed = value.radiusSpeed;
		Read(ref x_radiusSpeed);
		value.radiusSpeed = x_radiusSpeed;
		
		// Property radiusSpeedMultiplier from ShapeModule
		Single x_radiusSpeedMultiplier;
		Stream.ReadSingle(out x_radiusSpeedMultiplier);
		value.radiusSpeedMultiplier = x_radiusSpeedMultiplier;
		
		// Property radiusThickness from ShapeModule
		Single x_radiusThickness;
		Stream.ReadSingle(out x_radiusThickness);
		value.radiusThickness = x_radiusThickness;
		
		// Property angle from ShapeModule
		Single x_angle;
		Stream.ReadSingle(out x_angle);
		value.angle = x_angle;
		
		// Property length from ShapeModule
		Single x_length;
		Stream.ReadSingle(out x_length);
		value.length = x_length;
		
		// Property box from ShapeModule
		
		// Property boxThickness from ShapeModule
		Vector3 x_boxThickness;
		Stream.ReadVector3(out x_boxThickness);
		value.boxThickness = x_boxThickness;
		
		// Property meshShapeType from ShapeModule
		ParticleSystemMeshShapeType x_meshShapeType = value.meshShapeType;
		Read(ref x_meshShapeType);
		value.meshShapeType = x_meshShapeType;
		
		// Property mesh from ShapeModule
		
		// Property meshRenderer from ShapeModule
		
		// Property skinnedMeshRenderer from ShapeModule
		
		// Property useMeshMaterialIndex from ShapeModule
		Boolean x_useMeshMaterialIndex;
		Stream.ReadBoolean(out x_useMeshMaterialIndex);
		value.useMeshMaterialIndex = x_useMeshMaterialIndex;
		
		// Property meshMaterialIndex from ShapeModule
		Int32 x_meshMaterialIndex;
		Stream.ReadInt32(out x_meshMaterialIndex);
		value.meshMaterialIndex = x_meshMaterialIndex;
		
		// Property useMeshColors from ShapeModule
		Boolean x_useMeshColors;
		Stream.ReadBoolean(out x_useMeshColors);
		value.useMeshColors = x_useMeshColors;
		
		// Property normalOffset from ShapeModule
		Single x_normalOffset;
		Stream.ReadSingle(out x_normalOffset);
		value.normalOffset = x_normalOffset;
		
		// Property meshScale from ShapeModule
		
		// Property arc from ShapeModule
		Single x_arc;
		Stream.ReadSingle(out x_arc);
		value.arc = x_arc;
		
		// Property arcMode from ShapeModule
		ParticleSystemShapeMultiModeValue x_arcMode = value.arcMode;
		Read(ref x_arcMode);
		value.arcMode = x_arcMode;
		
		// Property arcSpread from ShapeModule
		Single x_arcSpread;
		Stream.ReadSingle(out x_arcSpread);
		value.arcSpread = x_arcSpread;
		
		// Property arcSpeed from ShapeModule
		ParticleSystem.MinMaxCurve x_arcSpeed = value.arcSpeed;
		Read(ref x_arcSpeed);
		value.arcSpeed = x_arcSpeed;
		
		// Property arcSpeedMultiplier from ShapeModule
		Single x_arcSpeedMultiplier;
		Stream.ReadSingle(out x_arcSpeedMultiplier);
		value.arcSpeedMultiplier = x_arcSpeedMultiplier;
		
		// Property donutRadius from ShapeModule
		Single x_donutRadius;
		Stream.ReadSingle(out x_donutRadius);
		value.donutRadius = x_donutRadius;
		
		// Property position from ShapeModule
		Vector3 x_position;
		Stream.ReadVector3(out x_position);
		value.position = x_position;
		
		// Property rotation from ShapeModule
		Vector3 x_rotation;
		Stream.ReadVector3(out x_rotation);
		value.rotation = x_rotation;
		
		// Property scale from ShapeModule
		Vector3 x_scale;
		Stream.ReadVector3(out x_scale);
		value.scale = x_scale;
		
		// Property randomDirection from ShapeModule
	}


	public void Read(ref ParticleSystemShapeType value)
	{
		int temp;
		Stream.ReadInt32(out temp);
		value = (ParticleSystemShapeType)temp;
	}


	public void Read(ref ParticleSystemShapeMultiModeValue value)
	{
		int temp;
		Stream.ReadInt32(out temp);
		value = (ParticleSystemShapeMultiModeValue)temp;
	}


	public void Read(ref ParticleSystemMeshShapeType value)
	{
		int temp;
		Stream.ReadInt32(out temp);
		value = (ParticleSystemMeshShapeType)temp;
	}


	public void Read(ref ParticleSystem.VelocityOverLifetimeModule value)
	{
		// Special case for enabled. Skip if disabled.
		bool x_enabled;
		Stream.ReadBoolean(out x_enabled);
		value.enabled = x_enabled;
		if(x_enabled == false) return;
		
		// Property x from VelocityOverLifetimeModule
		ParticleSystem.MinMaxCurve x_x = value.x;
		Read(ref x_x);
		value.x = x_x;
		
		// Property y from VelocityOverLifetimeModule
		ParticleSystem.MinMaxCurve x_y = value.y;
		Read(ref x_y);
		value.y = x_y;
		
		// Property z from VelocityOverLifetimeModule
		ParticleSystem.MinMaxCurve x_z = value.z;
		Read(ref x_z);
		value.z = x_z;
		
		// Property xMultiplier from VelocityOverLifetimeModule
		Single x_xMultiplier;
		Stream.ReadSingle(out x_xMultiplier);
		value.xMultiplier = x_xMultiplier;
		
		// Property yMultiplier from VelocityOverLifetimeModule
		Single x_yMultiplier;
		Stream.ReadSingle(out x_yMultiplier);
		value.yMultiplier = x_yMultiplier;
		
		// Property zMultiplier from VelocityOverLifetimeModule
		Single x_zMultiplier;
		Stream.ReadSingle(out x_zMultiplier);
		value.zMultiplier = x_zMultiplier;
		
		// Property space from VelocityOverLifetimeModule
		ParticleSystemSimulationSpace x_space = value.space;
		Read(ref x_space);
		value.space = x_space;
	}


	public void Read(ref ParticleSystem.LimitVelocityOverLifetimeModule value)
	{
		// Special case for enabled. Skip if disabled.
		bool x_enabled;
		Stream.ReadBoolean(out x_enabled);
		value.enabled = x_enabled;
		if(x_enabled == false) return;
		
		// Property limitX from LimitVelocityOverLifetimeModule
		ParticleSystem.MinMaxCurve x_limitX = value.limitX;
		Read(ref x_limitX);
		value.limitX = x_limitX;
		
		// Property limitXMultiplier from LimitVelocityOverLifetimeModule
		Single x_limitXMultiplier;
		Stream.ReadSingle(out x_limitXMultiplier);
		value.limitXMultiplier = x_limitXMultiplier;
		
		// Property limitY from LimitVelocityOverLifetimeModule
		ParticleSystem.MinMaxCurve x_limitY = value.limitY;
		Read(ref x_limitY);
		value.limitY = x_limitY;
		
		// Property limitYMultiplier from LimitVelocityOverLifetimeModule
		Single x_limitYMultiplier;
		Stream.ReadSingle(out x_limitYMultiplier);
		value.limitYMultiplier = x_limitYMultiplier;
		
		// Property limitZ from LimitVelocityOverLifetimeModule
		ParticleSystem.MinMaxCurve x_limitZ = value.limitZ;
		Read(ref x_limitZ);
		value.limitZ = x_limitZ;
		
		// Property limitZMultiplier from LimitVelocityOverLifetimeModule
		Single x_limitZMultiplier;
		Stream.ReadSingle(out x_limitZMultiplier);
		value.limitZMultiplier = x_limitZMultiplier;
		
		// Property limit from LimitVelocityOverLifetimeModule
		ParticleSystem.MinMaxCurve x_limit = value.limit;
		Read(ref x_limit);
		value.limit = x_limit;
		
		// Property limitMultiplier from LimitVelocityOverLifetimeModule
		Single x_limitMultiplier;
		Stream.ReadSingle(out x_limitMultiplier);
		value.limitMultiplier = x_limitMultiplier;
		
		// Property dampen from LimitVelocityOverLifetimeModule
		Single x_dampen;
		Stream.ReadSingle(out x_dampen);
		value.dampen = x_dampen;
		
		// Property separateAxes from LimitVelocityOverLifetimeModule
		Boolean x_separateAxes;
		Stream.ReadBoolean(out x_separateAxes);
		value.separateAxes = x_separateAxes;
		
		// Property space from LimitVelocityOverLifetimeModule
		ParticleSystemSimulationSpace x_space = value.space;
		Read(ref x_space);
		value.space = x_space;
		
		// Property drag from LimitVelocityOverLifetimeModule
		ParticleSystem.MinMaxCurve x_drag = value.drag;
		Read(ref x_drag);
		value.drag = x_drag;
		
		// Property dragMultiplier from LimitVelocityOverLifetimeModule
		Single x_dragMultiplier;
		Stream.ReadSingle(out x_dragMultiplier);
		value.dragMultiplier = x_dragMultiplier;
		
		// Property multiplyDragByParticleSize from LimitVelocityOverLifetimeModule
		Boolean x_multiplyDragByParticleSize;
		Stream.ReadBoolean(out x_multiplyDragByParticleSize);
		value.multiplyDragByParticleSize = x_multiplyDragByParticleSize;
		
		// Property multiplyDragByParticleVelocity from LimitVelocityOverLifetimeModule
		Boolean x_multiplyDragByParticleVelocity;
		Stream.ReadBoolean(out x_multiplyDragByParticleVelocity);
		value.multiplyDragByParticleVelocity = x_multiplyDragByParticleVelocity;
	}


	public void Read(ref ParticleSystem.InheritVelocityModule value)
	{
		// Special case for enabled. Skip if disabled.
		bool x_enabled;
		Stream.ReadBoolean(out x_enabled);
		value.enabled = x_enabled;
		if(x_enabled == false) return;
		
		// Property mode from InheritVelocityModule
		ParticleSystemInheritVelocityMode x_mode = value.mode;
		Read(ref x_mode);
		value.mode = x_mode;
		
		// Property curve from InheritVelocityModule
		ParticleSystem.MinMaxCurve x_curve = value.curve;
		Read(ref x_curve);
		value.curve = x_curve;
		
		// Property curveMultiplier from InheritVelocityModule
		Single x_curveMultiplier;
		Stream.ReadSingle(out x_curveMultiplier);
		value.curveMultiplier = x_curveMultiplier;
	}


	public void Read(ref ParticleSystemInheritVelocityMode value)
	{
		int temp;
		Stream.ReadInt32(out temp);
		value = (ParticleSystemInheritVelocityMode)temp;
	}


	public void Read(ref ParticleSystem.ForceOverLifetimeModule value)
	{
		// Special case for enabled. Skip if disabled.
		bool x_enabled;
		Stream.ReadBoolean(out x_enabled);
		value.enabled = x_enabled;
		if(x_enabled == false) return;
		
		// Property x from ForceOverLifetimeModule
		ParticleSystem.MinMaxCurve x_x = value.x;
		Read(ref x_x);
		value.x = x_x;
		
		// Property y from ForceOverLifetimeModule
		ParticleSystem.MinMaxCurve x_y = value.y;
		Read(ref x_y);
		value.y = x_y;
		
		// Property z from ForceOverLifetimeModule
		ParticleSystem.MinMaxCurve x_z = value.z;
		Read(ref x_z);
		value.z = x_z;
		
		// Property xMultiplier from ForceOverLifetimeModule
		Single x_xMultiplier;
		Stream.ReadSingle(out x_xMultiplier);
		value.xMultiplier = x_xMultiplier;
		
		// Property yMultiplier from ForceOverLifetimeModule
		Single x_yMultiplier;
		Stream.ReadSingle(out x_yMultiplier);
		value.yMultiplier = x_yMultiplier;
		
		// Property zMultiplier from ForceOverLifetimeModule
		Single x_zMultiplier;
		Stream.ReadSingle(out x_zMultiplier);
		value.zMultiplier = x_zMultiplier;
		
		// Property space from ForceOverLifetimeModule
		ParticleSystemSimulationSpace x_space = value.space;
		Read(ref x_space);
		value.space = x_space;
		
		// Property randomized from ForceOverLifetimeModule
		Boolean x_randomized;
		Stream.ReadBoolean(out x_randomized);
		value.randomized = x_randomized;
	}


	public void Read(ref ParticleSystem.ColorOverLifetimeModule value)
	{
		// Special case for enabled. Skip if disabled.
		bool x_enabled;
		Stream.ReadBoolean(out x_enabled);
		value.enabled = x_enabled;
		if(x_enabled == false) return;
		
		// Property color from ColorOverLifetimeModule
		ParticleSystem.MinMaxGradient x_color = value.color;
		Read(ref x_color);
		value.color = x_color;
	}


	public void Read(ref ParticleSystem.ColorBySpeedModule value)
	{
		// Special case for enabled. Skip if disabled.
		bool x_enabled;
		Stream.ReadBoolean(out x_enabled);
		value.enabled = x_enabled;
		if(x_enabled == false) return;
		
		// Property color from ColorBySpeedModule
		ParticleSystem.MinMaxGradient x_color = value.color;
		Read(ref x_color);
		value.color = x_color;
		
		// Property range from ColorBySpeedModule
		Vector2 x_range;
		Stream.ReadVector2(out x_range);
		value.range = x_range;
	}


	public void Read(ref ParticleSystem.SizeOverLifetimeModule value)
	{
		// Special case for enabled. Skip if disabled.
		bool x_enabled;
		Stream.ReadBoolean(out x_enabled);
		value.enabled = x_enabled;
		if(x_enabled == false) return;
		
		// Property size from SizeOverLifetimeModule
		ParticleSystem.MinMaxCurve x_size = value.size;
		Read(ref x_size);
		value.size = x_size;
		
		// Property sizeMultiplier from SizeOverLifetimeModule
		Single x_sizeMultiplier;
		Stream.ReadSingle(out x_sizeMultiplier);
		value.sizeMultiplier = x_sizeMultiplier;
		
		// Property x from SizeOverLifetimeModule
		ParticleSystem.MinMaxCurve x_x = value.x;
		Read(ref x_x);
		value.x = x_x;
		
		// Property xMultiplier from SizeOverLifetimeModule
		Single x_xMultiplier;
		Stream.ReadSingle(out x_xMultiplier);
		value.xMultiplier = x_xMultiplier;
		
		// Property y from SizeOverLifetimeModule
		ParticleSystem.MinMaxCurve x_y = value.y;
		Read(ref x_y);
		value.y = x_y;
		
		// Property yMultiplier from SizeOverLifetimeModule
		Single x_yMultiplier;
		Stream.ReadSingle(out x_yMultiplier);
		value.yMultiplier = x_yMultiplier;
		
		// Property z from SizeOverLifetimeModule
		ParticleSystem.MinMaxCurve x_z = value.z;
		Read(ref x_z);
		value.z = x_z;
		
		// Property zMultiplier from SizeOverLifetimeModule
		Single x_zMultiplier;
		Stream.ReadSingle(out x_zMultiplier);
		value.zMultiplier = x_zMultiplier;
		
		// Property separateAxes from SizeOverLifetimeModule
		Boolean x_separateAxes;
		Stream.ReadBoolean(out x_separateAxes);
		value.separateAxes = x_separateAxes;
	}


	public void Read(ref ParticleSystem.SizeBySpeedModule value)
	{
		// Special case for enabled. Skip if disabled.
		bool x_enabled;
		Stream.ReadBoolean(out x_enabled);
		value.enabled = x_enabled;
		if(x_enabled == false) return;
		
		// Property size from SizeBySpeedModule
		ParticleSystem.MinMaxCurve x_size = value.size;
		Read(ref x_size);
		value.size = x_size;
		
		// Property sizeMultiplier from SizeBySpeedModule
		Single x_sizeMultiplier;
		Stream.ReadSingle(out x_sizeMultiplier);
		value.sizeMultiplier = x_sizeMultiplier;
		
		// Property x from SizeBySpeedModule
		ParticleSystem.MinMaxCurve x_x = value.x;
		Read(ref x_x);
		value.x = x_x;
		
		// Property xMultiplier from SizeBySpeedModule
		Single x_xMultiplier;
		Stream.ReadSingle(out x_xMultiplier);
		value.xMultiplier = x_xMultiplier;
		
		// Property y from SizeBySpeedModule
		ParticleSystem.MinMaxCurve x_y = value.y;
		Read(ref x_y);
		value.y = x_y;
		
		// Property yMultiplier from SizeBySpeedModule
		Single x_yMultiplier;
		Stream.ReadSingle(out x_yMultiplier);
		value.yMultiplier = x_yMultiplier;
		
		// Property z from SizeBySpeedModule
		ParticleSystem.MinMaxCurve x_z = value.z;
		Read(ref x_z);
		value.z = x_z;
		
		// Property zMultiplier from SizeBySpeedModule
		Single x_zMultiplier;
		Stream.ReadSingle(out x_zMultiplier);
		value.zMultiplier = x_zMultiplier;
		
		// Property separateAxes from SizeBySpeedModule
		Boolean x_separateAxes;
		Stream.ReadBoolean(out x_separateAxes);
		value.separateAxes = x_separateAxes;
		
		// Property range from SizeBySpeedModule
		Vector2 x_range;
		Stream.ReadVector2(out x_range);
		value.range = x_range;
	}


	public void Read(ref ParticleSystem.RotationOverLifetimeModule value)
	{
		// Special case for enabled. Skip if disabled.
		bool x_enabled;
		Stream.ReadBoolean(out x_enabled);
		value.enabled = x_enabled;
		if(x_enabled == false) return;
		
		// Property x from RotationOverLifetimeModule
		ParticleSystem.MinMaxCurve x_x = value.x;
		Read(ref x_x);
		value.x = x_x;
		
		// Property xMultiplier from RotationOverLifetimeModule
		Single x_xMultiplier;
		Stream.ReadSingle(out x_xMultiplier);
		value.xMultiplier = x_xMultiplier;
		
		// Property y from RotationOverLifetimeModule
		ParticleSystem.MinMaxCurve x_y = value.y;
		Read(ref x_y);
		value.y = x_y;
		
		// Property yMultiplier from RotationOverLifetimeModule
		Single x_yMultiplier;
		Stream.ReadSingle(out x_yMultiplier);
		value.yMultiplier = x_yMultiplier;
		
		// Property z from RotationOverLifetimeModule
		ParticleSystem.MinMaxCurve x_z = value.z;
		Read(ref x_z);
		value.z = x_z;
		
		// Property zMultiplier from RotationOverLifetimeModule
		Single x_zMultiplier;
		Stream.ReadSingle(out x_zMultiplier);
		value.zMultiplier = x_zMultiplier;
		
		// Property separateAxes from RotationOverLifetimeModule
		Boolean x_separateAxes;
		Stream.ReadBoolean(out x_separateAxes);
		value.separateAxes = x_separateAxes;
	}


	public void Read(ref ParticleSystem.RotationBySpeedModule value)
	{
		// Special case for enabled. Skip if disabled.
		bool x_enabled;
		Stream.ReadBoolean(out x_enabled);
		value.enabled = x_enabled;
		if(x_enabled == false) return;
		
		// Property x from RotationBySpeedModule
		ParticleSystem.MinMaxCurve x_x = value.x;
		Read(ref x_x);
		value.x = x_x;
		
		// Property xMultiplier from RotationBySpeedModule
		Single x_xMultiplier;
		Stream.ReadSingle(out x_xMultiplier);
		value.xMultiplier = x_xMultiplier;
		
		// Property y from RotationBySpeedModule
		ParticleSystem.MinMaxCurve x_y = value.y;
		Read(ref x_y);
		value.y = x_y;
		
		// Property yMultiplier from RotationBySpeedModule
		Single x_yMultiplier;
		Stream.ReadSingle(out x_yMultiplier);
		value.yMultiplier = x_yMultiplier;
		
		// Property z from RotationBySpeedModule
		ParticleSystem.MinMaxCurve x_z = value.z;
		Read(ref x_z);
		value.z = x_z;
		
		// Property zMultiplier from RotationBySpeedModule
		Single x_zMultiplier;
		Stream.ReadSingle(out x_zMultiplier);
		value.zMultiplier = x_zMultiplier;
		
		// Property separateAxes from RotationBySpeedModule
		Boolean x_separateAxes;
		Stream.ReadBoolean(out x_separateAxes);
		value.separateAxes = x_separateAxes;
		
		// Property range from RotationBySpeedModule
		Vector2 x_range;
		Stream.ReadVector2(out x_range);
		value.range = x_range;
	}


	public void Read(ref ParticleSystem.ExternalForcesModule value)
	{
		// Special case for enabled. Skip if disabled.
		bool x_enabled;
		Stream.ReadBoolean(out x_enabled);
		value.enabled = x_enabled;
		if(x_enabled == false) return;
		
		// Property multiplier from ExternalForcesModule
		Single x_multiplier;
		Stream.ReadSingle(out x_multiplier);
		value.multiplier = x_multiplier;
	}


	public void Read(ref ParticleSystem.NoiseModule value)
	{
		// Special case for enabled. Skip if disabled.
		bool x_enabled;
		Stream.ReadBoolean(out x_enabled);
		value.enabled = x_enabled;
		if(x_enabled == false) return;
		
		// Property separateAxes from NoiseModule
		Boolean x_separateAxes;
		Stream.ReadBoolean(out x_separateAxes);
		value.separateAxes = x_separateAxes;
		
		// Property strength from NoiseModule
		ParticleSystem.MinMaxCurve x_strength = value.strength;
		Read(ref x_strength);
		value.strength = x_strength;
		
		// Property strengthMultiplier from NoiseModule
		Single x_strengthMultiplier;
		Stream.ReadSingle(out x_strengthMultiplier);
		value.strengthMultiplier = x_strengthMultiplier;
		
		// Property strengthX from NoiseModule
		ParticleSystem.MinMaxCurve x_strengthX = value.strengthX;
		Read(ref x_strengthX);
		value.strengthX = x_strengthX;
		
		// Property strengthXMultiplier from NoiseModule
		Single x_strengthXMultiplier;
		Stream.ReadSingle(out x_strengthXMultiplier);
		value.strengthXMultiplier = x_strengthXMultiplier;
		
		// Property strengthY from NoiseModule
		ParticleSystem.MinMaxCurve x_strengthY = value.strengthY;
		Read(ref x_strengthY);
		value.strengthY = x_strengthY;
		
		// Property strengthYMultiplier from NoiseModule
		Single x_strengthYMultiplier;
		Stream.ReadSingle(out x_strengthYMultiplier);
		value.strengthYMultiplier = x_strengthYMultiplier;
		
		// Property strengthZ from NoiseModule
		ParticleSystem.MinMaxCurve x_strengthZ = value.strengthZ;
		Read(ref x_strengthZ);
		value.strengthZ = x_strengthZ;
		
		// Property strengthZMultiplier from NoiseModule
		Single x_strengthZMultiplier;
		Stream.ReadSingle(out x_strengthZMultiplier);
		value.strengthZMultiplier = x_strengthZMultiplier;
		
		// Property frequency from NoiseModule
		Single x_frequency;
		Stream.ReadSingle(out x_frequency);
		value.frequency = x_frequency;
		
		// Property damping from NoiseModule
		Boolean x_damping;
		Stream.ReadBoolean(out x_damping);
		value.damping = x_damping;
		
		// Property octaveCount from NoiseModule
		Int32 x_octaveCount;
		Stream.ReadInt32(out x_octaveCount);
		value.octaveCount = x_octaveCount;
		
		// Property octaveMultiplier from NoiseModule
		Single x_octaveMultiplier;
		Stream.ReadSingle(out x_octaveMultiplier);
		value.octaveMultiplier = x_octaveMultiplier;
		
		// Property octaveScale from NoiseModule
		Single x_octaveScale;
		Stream.ReadSingle(out x_octaveScale);
		value.octaveScale = x_octaveScale;
		
		// Property quality from NoiseModule
		ParticleSystemNoiseQuality x_quality = value.quality;
		Read(ref x_quality);
		value.quality = x_quality;
		
		// Property scrollSpeed from NoiseModule
		ParticleSystem.MinMaxCurve x_scrollSpeed = value.scrollSpeed;
		Read(ref x_scrollSpeed);
		value.scrollSpeed = x_scrollSpeed;
		
		// Property scrollSpeedMultiplier from NoiseModule
		Single x_scrollSpeedMultiplier;
		Stream.ReadSingle(out x_scrollSpeedMultiplier);
		value.scrollSpeedMultiplier = x_scrollSpeedMultiplier;
		
		// Property remapEnabled from NoiseModule
		Boolean x_remapEnabled;
		Stream.ReadBoolean(out x_remapEnabled);
		value.remapEnabled = x_remapEnabled;
		
		// Property remap from NoiseModule
		ParticleSystem.MinMaxCurve x_remap = value.remap;
		Read(ref x_remap);
		value.remap = x_remap;
		
		// Property remapMultiplier from NoiseModule
		Single x_remapMultiplier;
		Stream.ReadSingle(out x_remapMultiplier);
		value.remapMultiplier = x_remapMultiplier;
		
		// Property remapX from NoiseModule
		ParticleSystem.MinMaxCurve x_remapX = value.remapX;
		Read(ref x_remapX);
		value.remapX = x_remapX;
		
		// Property remapXMultiplier from NoiseModule
		Single x_remapXMultiplier;
		Stream.ReadSingle(out x_remapXMultiplier);
		value.remapXMultiplier = x_remapXMultiplier;
		
		// Property remapY from NoiseModule
		ParticleSystem.MinMaxCurve x_remapY = value.remapY;
		Read(ref x_remapY);
		value.remapY = x_remapY;
		
		// Property remapYMultiplier from NoiseModule
		Single x_remapYMultiplier;
		Stream.ReadSingle(out x_remapYMultiplier);
		value.remapYMultiplier = x_remapYMultiplier;
		
		// Property remapZ from NoiseModule
		ParticleSystem.MinMaxCurve x_remapZ = value.remapZ;
		Read(ref x_remapZ);
		value.remapZ = x_remapZ;
		
		// Property remapZMultiplier from NoiseModule
		Single x_remapZMultiplier;
		Stream.ReadSingle(out x_remapZMultiplier);
		value.remapZMultiplier = x_remapZMultiplier;
		
		// Property positionAmount from NoiseModule
		ParticleSystem.MinMaxCurve x_positionAmount = value.positionAmount;
		Read(ref x_positionAmount);
		value.positionAmount = x_positionAmount;
		
		// Property rotationAmount from NoiseModule
		ParticleSystem.MinMaxCurve x_rotationAmount = value.rotationAmount;
		Read(ref x_rotationAmount);
		value.rotationAmount = x_rotationAmount;
		
		// Property sizeAmount from NoiseModule
		ParticleSystem.MinMaxCurve x_sizeAmount = value.sizeAmount;
		Read(ref x_sizeAmount);
		value.sizeAmount = x_sizeAmount;
	}


	public void Read(ref ParticleSystemNoiseQuality value)
	{
		int temp;
		Stream.ReadInt32(out temp);
		value = (ParticleSystemNoiseQuality)temp;
	}


	public void Read(ref ParticleSystem.CollisionModule value)
	{
		// Special case for enabled. Skip if disabled.
		bool x_enabled;
		Stream.ReadBoolean(out x_enabled);
		value.enabled = x_enabled;
		if(x_enabled == false) return;
		
		// Property type from CollisionModule
		ParticleSystemCollisionType x_type = value.type;
		Read(ref x_type);
		value.type = x_type;
		
		// Property mode from CollisionModule
		ParticleSystemCollisionMode x_mode = value.mode;
		Read(ref x_mode);
		value.mode = x_mode;
		
		// Property dampen from CollisionModule
		ParticleSystem.MinMaxCurve x_dampen = value.dampen;
		Read(ref x_dampen);
		value.dampen = x_dampen;
		
		// Property dampenMultiplier from CollisionModule
		Single x_dampenMultiplier;
		Stream.ReadSingle(out x_dampenMultiplier);
		value.dampenMultiplier = x_dampenMultiplier;
		
		// Property bounce from CollisionModule
		ParticleSystem.MinMaxCurve x_bounce = value.bounce;
		Read(ref x_bounce);
		value.bounce = x_bounce;
		
		// Property bounceMultiplier from CollisionModule
		Single x_bounceMultiplier;
		Stream.ReadSingle(out x_bounceMultiplier);
		value.bounceMultiplier = x_bounceMultiplier;
		
		// Property lifetimeLoss from CollisionModule
		ParticleSystem.MinMaxCurve x_lifetimeLoss = value.lifetimeLoss;
		Read(ref x_lifetimeLoss);
		value.lifetimeLoss = x_lifetimeLoss;
		
		// Property lifetimeLossMultiplier from CollisionModule
		Single x_lifetimeLossMultiplier;
		Stream.ReadSingle(out x_lifetimeLossMultiplier);
		value.lifetimeLossMultiplier = x_lifetimeLossMultiplier;
		
		// Property minKillSpeed from CollisionModule
		Single x_minKillSpeed;
		Stream.ReadSingle(out x_minKillSpeed);
		value.minKillSpeed = x_minKillSpeed;
		
		// Property maxKillSpeed from CollisionModule
		Single x_maxKillSpeed;
		Stream.ReadSingle(out x_maxKillSpeed);
		value.maxKillSpeed = x_maxKillSpeed;
		
		// Property collidesWith from CollisionModule
		LayerMask x_collidesWith = value.collidesWith;
		Read(ref x_collidesWith);
		value.collidesWith = x_collidesWith;
		
		// Property enableDynamicColliders from CollisionModule
		Boolean x_enableDynamicColliders;
		Stream.ReadBoolean(out x_enableDynamicColliders);
		value.enableDynamicColliders = x_enableDynamicColliders;
		
		// Property enableInteriorCollisions from CollisionModule
		
		// Property maxCollisionShapes from CollisionModule
		Int32 x_maxCollisionShapes;
		Stream.ReadInt32(out x_maxCollisionShapes);
		value.maxCollisionShapes = x_maxCollisionShapes;
		
		// Property quality from CollisionModule
		ParticleSystemCollisionQuality x_quality = value.quality;
		Read(ref x_quality);
		value.quality = x_quality;
		
		// Property voxelSize from CollisionModule
		Single x_voxelSize;
		Stream.ReadSingle(out x_voxelSize);
		value.voxelSize = x_voxelSize;
		
		// Property radiusScale from CollisionModule
		Single x_radiusScale;
		Stream.ReadSingle(out x_radiusScale);
		value.radiusScale = x_radiusScale;
		
		// Property sendCollisionMessages from CollisionModule
		Boolean x_sendCollisionMessages;
		Stream.ReadBoolean(out x_sendCollisionMessages);
		value.sendCollisionMessages = x_sendCollisionMessages;
		
		// Property colliderForce from CollisionModule
		Single x_colliderForce;
		Stream.ReadSingle(out x_colliderForce);
		value.colliderForce = x_colliderForce;
		
		// Property multiplyColliderForceByCollisionAngle from CollisionModule
		Boolean x_multiplyColliderForceByCollisionAngle;
		Stream.ReadBoolean(out x_multiplyColliderForceByCollisionAngle);
		value.multiplyColliderForceByCollisionAngle = x_multiplyColliderForceByCollisionAngle;
		
		// Property multiplyColliderForceByParticleSpeed from CollisionModule
		Boolean x_multiplyColliderForceByParticleSpeed;
		Stream.ReadBoolean(out x_multiplyColliderForceByParticleSpeed);
		value.multiplyColliderForceByParticleSpeed = x_multiplyColliderForceByParticleSpeed;
		
		// Property multiplyColliderForceByParticleSize from CollisionModule
		Boolean x_multiplyColliderForceByParticleSize;
		Stream.ReadBoolean(out x_multiplyColliderForceByParticleSize);
		value.multiplyColliderForceByParticleSize = x_multiplyColliderForceByParticleSize;
		
		// Property maxPlaneCount from CollisionModule
	}


	public void Read(ref ParticleSystemCollisionType value)
	{
		int temp;
		Stream.ReadInt32(out temp);
		value = (ParticleSystemCollisionType)temp;
	}


	public void Read(ref ParticleSystemCollisionMode value)
	{
		int temp;
		Stream.ReadInt32(out temp);
		value = (ParticleSystemCollisionMode)temp;
	}


	public void Read(ref LayerMask value)
	{
		
		// Property value from LayerMask
		Int32 x_value;
		Stream.ReadInt32(out x_value);
		value.value = x_value;
	}


	public void Read(ref ParticleSystemCollisionQuality value)
	{
		int temp;
		Stream.ReadInt32(out temp);
		value = (ParticleSystemCollisionQuality)temp;
	}


	public void Read(ref ParticleSystem.TriggerModule value)
	{
		// Special case for enabled. Skip if disabled.
		bool x_enabled;
		Stream.ReadBoolean(out x_enabled);
		value.enabled = x_enabled;
		if(x_enabled == false) return;
		
		// Property inside from TriggerModule
		ParticleSystemOverlapAction x_inside = value.inside;
		Read(ref x_inside);
		value.inside = x_inside;
		
		// Property outside from TriggerModule
		ParticleSystemOverlapAction x_outside = value.outside;
		Read(ref x_outside);
		value.outside = x_outside;
		
		// Property enter from TriggerModule
		ParticleSystemOverlapAction x_enter = value.enter;
		Read(ref x_enter);
		value.enter = x_enter;
		
		// Property exit from TriggerModule
		ParticleSystemOverlapAction x_exit = value.exit;
		Read(ref x_exit);
		value.exit = x_exit;
		
		// Property radiusScale from TriggerModule
		Single x_radiusScale;
		Stream.ReadSingle(out x_radiusScale);
		value.radiusScale = x_radiusScale;
		
		// Property maxColliderCount from TriggerModule
	}


	public void Read(ref ParticleSystemOverlapAction value)
	{
		int temp;
		Stream.ReadInt32(out temp);
		value = (ParticleSystemOverlapAction)temp;
	}


	public void Read(ref ParticleSystem.SubEmittersModule value)
	{
		// Special case for enabled. Skip if disabled.
		bool x_enabled;
		Stream.ReadBoolean(out x_enabled);
		value.enabled = x_enabled;
		if(x_enabled == false) return;
		
		// Property subEmittersCount from SubEmittersModule
		
		// Property birth0 from SubEmittersModule
		
		// Property birth1 from SubEmittersModule
		
		// Property collision0 from SubEmittersModule
		
		// Property collision1 from SubEmittersModule
		
		// Property death0 from SubEmittersModule
		
		// Property death1 from SubEmittersModule
	}


	public void Read(ref ParticleSystem.TextureSheetAnimationModule value)
	{
		// Special case for enabled. Skip if disabled.
		bool x_enabled;
		Stream.ReadBoolean(out x_enabled);
		value.enabled = x_enabled;
		if(x_enabled == false) return;
		
		// Property mode from TextureSheetAnimationModule
		ParticleSystemAnimationMode x_mode = value.mode;
		Read(ref x_mode);
		value.mode = x_mode;
		
		// Property numTilesX from TextureSheetAnimationModule
		Int32 x_numTilesX;
		Stream.ReadInt32(out x_numTilesX);
		value.numTilesX = x_numTilesX;
		
		// Property numTilesY from TextureSheetAnimationModule
		Int32 x_numTilesY;
		Stream.ReadInt32(out x_numTilesY);
		value.numTilesY = x_numTilesY;
		
		// Property animation from TextureSheetAnimationModule
		ParticleSystemAnimationType x_animation = value.animation;
		Read(ref x_animation);
		value.animation = x_animation;
		
		// Property useRandomRow from TextureSheetAnimationModule
		Boolean x_useRandomRow;
		Stream.ReadBoolean(out x_useRandomRow);
		value.useRandomRow = x_useRandomRow;
		
		// Property frameOverTime from TextureSheetAnimationModule
		ParticleSystem.MinMaxCurve x_frameOverTime = value.frameOverTime;
		Read(ref x_frameOverTime);
		value.frameOverTime = x_frameOverTime;
		
		// Property frameOverTimeMultiplier from TextureSheetAnimationModule
		Single x_frameOverTimeMultiplier;
		Stream.ReadSingle(out x_frameOverTimeMultiplier);
		value.frameOverTimeMultiplier = x_frameOverTimeMultiplier;
		
		// Property startFrame from TextureSheetAnimationModule
		ParticleSystem.MinMaxCurve x_startFrame = value.startFrame;
		Read(ref x_startFrame);
		value.startFrame = x_startFrame;
		
		// Property startFrameMultiplier from TextureSheetAnimationModule
		Single x_startFrameMultiplier;
		Stream.ReadSingle(out x_startFrameMultiplier);
		value.startFrameMultiplier = x_startFrameMultiplier;
		
		// Property cycleCount from TextureSheetAnimationModule
		Int32 x_cycleCount;
		Stream.ReadInt32(out x_cycleCount);
		value.cycleCount = x_cycleCount;
		
		// Property rowIndex from TextureSheetAnimationModule
		Int32 x_rowIndex;
		Stream.ReadInt32(out x_rowIndex);
		value.rowIndex = x_rowIndex;
		
		// Property uvChannelMask from TextureSheetAnimationModule
		UVChannelFlags x_uvChannelMask = value.uvChannelMask;
		Read(ref x_uvChannelMask);
		value.uvChannelMask = x_uvChannelMask;
		
		// Property flipU from TextureSheetAnimationModule
		Single x_flipU;
		Stream.ReadSingle(out x_flipU);
		value.flipU = x_flipU;
		
		// Property flipV from TextureSheetAnimationModule
		Single x_flipV;
		Stream.ReadSingle(out x_flipV);
		value.flipV = x_flipV;
		
		// Property spriteCount from TextureSheetAnimationModule
	}


	public void Read(ref ParticleSystemAnimationMode value)
	{
		int temp;
		Stream.ReadInt32(out temp);
		value = (ParticleSystemAnimationMode)temp;
	}


	public void Read(ref ParticleSystemAnimationType value)
	{
		int temp;
		Stream.ReadInt32(out temp);
		value = (ParticleSystemAnimationType)temp;
	}


	public void Read(ref UVChannelFlags value)
	{
		int temp;
		Stream.ReadInt32(out temp);
		value = (UVChannelFlags)temp;
	}


	public void Read(ref ParticleSystem.LightsModule value)
	{
		// Special case for enabled. Skip if disabled.
		bool x_enabled;
		Stream.ReadBoolean(out x_enabled);
		value.enabled = x_enabled;
		if(x_enabled == false) return;
		
		// Property ratio from LightsModule
		Single x_ratio;
		Stream.ReadSingle(out x_ratio);
		value.ratio = x_ratio;
		
		// Property useRandomDistribution from LightsModule
		Boolean x_useRandomDistribution;
		Stream.ReadBoolean(out x_useRandomDistribution);
		value.useRandomDistribution = x_useRandomDistribution;
		
		// Property light from LightsModule
		
		// Property useParticleColor from LightsModule
		Boolean x_useParticleColor;
		Stream.ReadBoolean(out x_useParticleColor);
		value.useParticleColor = x_useParticleColor;
		
		// Property sizeAffectsRange from LightsModule
		Boolean x_sizeAffectsRange;
		Stream.ReadBoolean(out x_sizeAffectsRange);
		value.sizeAffectsRange = x_sizeAffectsRange;
		
		// Property alphaAffectsIntensity from LightsModule
		Boolean x_alphaAffectsIntensity;
		Stream.ReadBoolean(out x_alphaAffectsIntensity);
		value.alphaAffectsIntensity = x_alphaAffectsIntensity;
		
		// Property range from LightsModule
		ParticleSystem.MinMaxCurve x_range = value.range;
		Read(ref x_range);
		value.range = x_range;
		
		// Property rangeMultiplier from LightsModule
		Single x_rangeMultiplier;
		Stream.ReadSingle(out x_rangeMultiplier);
		value.rangeMultiplier = x_rangeMultiplier;
		
		// Property intensity from LightsModule
		ParticleSystem.MinMaxCurve x_intensity = value.intensity;
		Read(ref x_intensity);
		value.intensity = x_intensity;
		
		// Property intensityMultiplier from LightsModule
		Single x_intensityMultiplier;
		Stream.ReadSingle(out x_intensityMultiplier);
		value.intensityMultiplier = x_intensityMultiplier;
		
		// Property maxLights from LightsModule
		Int32 x_maxLights;
		Stream.ReadInt32(out x_maxLights);
		value.maxLights = x_maxLights;
	}


	public void Read(ref ParticleSystem.TrailModule value)
	{
		// Special case for enabled. Skip if disabled.
		bool x_enabled;
		Stream.ReadBoolean(out x_enabled);
		value.enabled = x_enabled;
		if(x_enabled == false) return;
		
		// Property ratio from TrailModule
		Single x_ratio;
		Stream.ReadSingle(out x_ratio);
		value.ratio = x_ratio;
		
		// Property lifetime from TrailModule
		ParticleSystem.MinMaxCurve x_lifetime = value.lifetime;
		Read(ref x_lifetime);
		value.lifetime = x_lifetime;
		
		// Property lifetimeMultiplier from TrailModule
		Single x_lifetimeMultiplier;
		Stream.ReadSingle(out x_lifetimeMultiplier);
		value.lifetimeMultiplier = x_lifetimeMultiplier;
		
		// Property minVertexDistance from TrailModule
		Single x_minVertexDistance;
		Stream.ReadSingle(out x_minVertexDistance);
		value.minVertexDistance = x_minVertexDistance;
		
		// Property textureMode from TrailModule
		ParticleSystemTrailTextureMode x_textureMode = value.textureMode;
		Read(ref x_textureMode);
		value.textureMode = x_textureMode;
		
		// Property worldSpace from TrailModule
		Boolean x_worldSpace;
		Stream.ReadBoolean(out x_worldSpace);
		value.worldSpace = x_worldSpace;
		
		// Property dieWithParticles from TrailModule
		Boolean x_dieWithParticles;
		Stream.ReadBoolean(out x_dieWithParticles);
		value.dieWithParticles = x_dieWithParticles;
		
		// Property sizeAffectsWidth from TrailModule
		Boolean x_sizeAffectsWidth;
		Stream.ReadBoolean(out x_sizeAffectsWidth);
		value.sizeAffectsWidth = x_sizeAffectsWidth;
		
		// Property sizeAffectsLifetime from TrailModule
		Boolean x_sizeAffectsLifetime;
		Stream.ReadBoolean(out x_sizeAffectsLifetime);
		value.sizeAffectsLifetime = x_sizeAffectsLifetime;
		
		// Property inheritParticleColor from TrailModule
		Boolean x_inheritParticleColor;
		Stream.ReadBoolean(out x_inheritParticleColor);
		value.inheritParticleColor = x_inheritParticleColor;
		
		// Property colorOverLifetime from TrailModule
		ParticleSystem.MinMaxGradient x_colorOverLifetime = value.colorOverLifetime;
		Read(ref x_colorOverLifetime);
		value.colorOverLifetime = x_colorOverLifetime;
		
		// Property widthOverTrail from TrailModule
		ParticleSystem.MinMaxCurve x_widthOverTrail = value.widthOverTrail;
		Read(ref x_widthOverTrail);
		value.widthOverTrail = x_widthOverTrail;
		
		// Property widthOverTrailMultiplier from TrailModule
		Single x_widthOverTrailMultiplier;
		Stream.ReadSingle(out x_widthOverTrailMultiplier);
		value.widthOverTrailMultiplier = x_widthOverTrailMultiplier;
		
		// Property colorOverTrail from TrailModule
		ParticleSystem.MinMaxGradient x_colorOverTrail = value.colorOverTrail;
		Read(ref x_colorOverTrail);
		value.colorOverTrail = x_colorOverTrail;
		
		// Property generateLightingData from TrailModule
		Boolean x_generateLightingData;
		Stream.ReadBoolean(out x_generateLightingData);
		value.generateLightingData = x_generateLightingData;
	}


	public void Read(ref ParticleSystemTrailTextureMode value)
	{
		int temp;
		Stream.ReadInt32(out temp);
		value = (ParticleSystemTrailTextureMode)temp;
	}


	public void Read(ref ParticleSystem.CustomDataModule value)
	{
		// Special case for enabled. Skip if disabled.
		bool x_enabled;
		Stream.ReadBoolean(out x_enabled);
		value.enabled = x_enabled;
		if(x_enabled == false) return;
	}

    /*
	public void Read(ref MeshTunnelAnimator value)
	{
		// Special case for enabled. Skip if disabled.
		bool x_enabled;
		Stream.ReadBoolean(out x_enabled);
		value.enabled = x_enabled;
		if(x_enabled == false) return;
		
		// Property useGUILayout from MonoBehaviour
		
		// Property runInEditMode from MonoBehaviour
		
		// Property isActiveAndEnabled from Behaviour
		
		// Property transform from Component
		
		// Property gameObject from Component
		
		// Property tag from Component
		
		// Property rigidbody from Component
		
		// Property rigidbody2D from Component
		
		// Property camera from Component
		
		// Property light from Component
		
		// Property animation from Component
		
		// Property constantForce from Component
		
		// Property renderer from Component
		
		// Property audio from Component
		
		// Property guiText from Component
		
		// Property networkView from Component
		
		// Property guiElement from Component
		
		// Property guiTexture from Component
		
		// Property collider from Component
		
		// Property collider2D from Component
		
		// Property hingeJoint from Component
		
		// Property particleEmitter from Component
		
		// Property particleSystem from Component
		
		// Property name from Object
		
		// Property hideFlags from Object

		// Field GameObject

		// Field Int32
		Stream.ReadInt32(out value.NumberToSpawn);

		// Field Boolean
		Stream.ReadBoolean(out value.SpawnOnGrid);

		// Field Vector3Int
		Read(ref value.GridSize);

		// Field Boolean
		Stream.ReadBoolean(out value.EnableGridMotionLock);

		// Field Vector3Int
		Read(ref value.LockBoxMin);

		// Field Vector3Int
		Read(ref value.LockBoxMax);

		// Field Vector3
		Stream.ReadVector3(out value.GridSpacing);

		// Field Material

		// Field Boolean
		Stream.ReadBoolean(out value.SpawnWithZeroTime);

		// Field Single
		Stream.ReadSingle(out value.CycleTime);

		// Field Single
		Stream.ReadSingle(out value.SpeedVariance);

		// Field Single
		Stream.ReadSingle(out value.SpeedOffset);

		// Field AnimationCurve
		Read(ref value.Location);

		// Field Vector3
		Stream.ReadVector3(out value.DirectionOfMotion);

		// Field AnimationCurve
		Read(ref value.Rotation);

		// Field Vector3
		Stream.ReadVector3(out value.AxisOfRotation);

		// Field Single
		Stream.ReadSingle(out value.RotationScale);

		// Field AnimationCurve
		Read(ref value.Scale);

		// Field Vector3
		Stream.ReadVector3(out value.ScaleFactor);

		// Field Gradient
		Read(ref value.Color);
	}


	public void Read(ref SpawnDriftingObjects value)
	{
		// Special case for enabled. Skip if disabled.
		bool x_enabled;
		Stream.ReadBoolean(out x_enabled);
		value.enabled = x_enabled;
		if(x_enabled == false) return;
		
		// Property useGUILayout from MonoBehaviour
		
		// Property runInEditMode from MonoBehaviour
		
		// Property isActiveAndEnabled from Behaviour
		
		// Property transform from Component
		
		// Property gameObject from Component
		
		// Property tag from Component
		
		// Property rigidbody from Component
		
		// Property rigidbody2D from Component
		
		// Property camera from Component
		
		// Property light from Component
		
		// Property animation from Component
		
		// Property constantForce from Component
		
		// Property renderer from Component
		
		// Property audio from Component
		
		// Property guiText from Component
		
		// Property networkView from Component
		
		// Property guiElement from Component
		
		// Property guiTexture from Component
		
		// Property collider from Component
		
		// Property collider2D from Component
		
		// Property hingeJoint from Component
		
		// Property particleEmitter from Component
		
		// Property particleSystem from Component
		
		// Property name from Object
		
		// Property hideFlags from Object

		// Field GameObject

		// Field Int32
		Stream.ReadInt32(out value.SpawnCount);

		// Field Single
		Stream.ReadSingle(out value.RadiusMin);

		// Field Single
		Stream.ReadSingle(out value.RadiusMax);

		// Field Single
		Stream.ReadSingle(out value.RandomScaleMin);

		// Field Single
		Stream.ReadSingle(out value.RandomScaleMax);

		// Field Single
		Stream.ReadSingle(out value.ItemSpinSpeedMin);

		// Field Single
		Stream.ReadSingle(out value.ItemSpinSpeedMax);

		// Field Single
		Stream.ReadSingle(out value.OverallSpinSpeedMin);

		// Field Single
		Stream.ReadSingle(out value.OverallSpinSpeedMax);

		// Field List<GameObject>

		// Field List<Single>
		//Read(ref value.SpawnedObjectSpins);

		// Field Single
		Stream.ReadSingle(out value.OverallSpinSpeed);
	}
    */

	public void Read(ref LevelScene value)
	{

		// Field String
		Stream.ReadString(out value.name);

		// Field LevelObject
		Read(ref value.root);

		// Field Int32
		Stream.ReadInt32(out value.skyboxId);

		// Field Vector3
		Stream.ReadVector3(out value.sunDirection);

		// Field Vector3
		Stream.ReadVector3(out value.previewPosition);

		// Field Quaternion
		Stream.ReadQuaternion(out value.previewOrientation);
	}


	public void Read(ref LevelObject value)
	{

		// Field String
		Stream.ReadString(out value.name);

		// Field Vector3
		Stream.ReadVector3(out value.position);

		// Field Quaternion
		Stream.ReadQuaternion(out value.rotation);

		// Field Vector3
		Stream.ReadVector3(out value.scale);

		// Field LevelMesh
		Read(ref value.mesh);

		// Field Int32
		Stream.ReadInt32(out value.LargestChildVertexCount);

		// Field String
		Stream.ReadString(out value.prefabItem);

		// Field SimpleBuffer
		Read(ref value.serializedContent);

		// Field Dictionary<String,Object>
		Read(ref value.properties);

		// Field List<LevelObject>
		Read(ref value.children);
	}


	public void Read(ref LevelMesh value)
	{

        // Property HasNormal from LevelMesh

        // Property HasUV1 from LevelMesh

        // Property HasUV2 from LevelMesh

        // Property IsStatic from LevelMesh

        // Field Int32
        int tmp;
		Stream.ReadInt32(out tmp);
        value.Flags = (LevelMesh.MeshFlags)tmp;

        // Field Int32
        Stream.ReadInt32(out value.vertexCount);

		// Field SimpleBuffer
		Read(ref value.verts);

		// Field Int32
		Stream.ReadInt32(out value.indexCount);

		// Field SimpleBuffer
		Read(ref value.indices);

		// Field List<LevelSubMesh>
		Read(ref value.subMeshes);

		// Field List<String>
		Read(ref value.materials);

		// Field Int32
		Stream.ReadInt32(out value.lightmapIndex);

		// Field Vector4
		Stream.ReadVector4(out value.lightmapScaleOffset);

        Vector3 b1, b2;
        Stream.ReadVector3(out b1);
        Stream.ReadVector3(out b2);
        value.bounds = new Bounds(b1, b2);
    }


	public void Read(ref LevelSubMesh value)
	{

		// Field Int32
		Stream.ReadInt32(out value.start);

		// Field Int32
		Stream.ReadInt32(out value.count);

		// Field String
		Stream.ReadString(out value.material);
	}
}
#endif
