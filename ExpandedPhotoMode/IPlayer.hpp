#pragma once

#include "sdk.hpp"
#include "BaseTypes.h"

namespace Nesae::ExpandedPhotoMode
{
	class IPlayer
	{
	public:
		SDK::Player* GetInstance();

		void RotateByXAxis(float amount);
		void RotateByYAxis(float amount);
	};
}
