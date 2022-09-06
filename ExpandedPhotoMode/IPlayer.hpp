#pragma once

#include "sdk.hpp"
#include "BaseTypes.h"

namespace Nesae::ExpandedPhotoMode
{
	enum class RotationAxis
	{
		X,
		Y,
		Z
	};

	class IPlayer
	{
		bool initialized = false;

		void RotateByXAxis(float amount);
		void RotateByYAxis(float amount);
		void RotateByZAxis(float amount);

		SDK::Player OriginalPlayer;

	public:
		IPlayer();
		~IPlayer();

		SDK::Player* GetInstance();

		void Rotate(RotationAxis axis, float amount);
		void Restore();
	
		void Initialize();
		void Uninitialize();
		bool IsInitialized();
	
		__declspec(property(get = IsInitialized)) bool Initialized;

	};
}
