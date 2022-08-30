#pragma once

#include "sdk.hpp"

typedef unsigned __int64 QWORD;

namespace Nesae::ExpandedPhotoMode
{
	class IPhotoMode
	{
		void EnableOverride();
		void DisableOverride();

	public:
		IPhotoMode();
		~IPhotoMode();

		bool IsPhotoMode();
		PhotoModeCameraController* GetInstance();

		void ChangeRoll(float amount);
		void ChangeFoV(float amount);
	};
}