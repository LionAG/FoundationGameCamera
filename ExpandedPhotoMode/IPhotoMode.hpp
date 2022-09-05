#pragma once

#include "sdk.hpp"
#include "BaseTypes.h"

typedef unsigned __int64 QWORD;

namespace Nesae::ExpandedPhotoMode
{
	class IPhotoMode
	{
		void EnableOverride();
		void DisableOverride();
		
		Vec3 SavedPosition[9];

	public:
		IPhotoMode();
		~IPhotoMode();

		bool IsPhotoMode();
		SDK::PhotoModeCameraController* GetInstance();

		void ChangeRoll(float amount);
		void ChangeFoV(float amount);

		void SavePosition(int index);
		void RestorePosition(int index);
	};
}