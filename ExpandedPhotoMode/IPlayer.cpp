#include "IPlayer.hpp"
#include <Windows.h>

Nesae::ExpandedPhotoMode::SDK::Player* Nesae::ExpandedPhotoMode::IPlayer::GetInstance()
{
    auto moduleBase = (QWORD)GetModuleHandle(NULL);
    auto instance = *((QWORD*)(moduleBase + 0x14690B8));

    return reinterpret_cast<SDK::Player*>(instance);
}

void Nesae::ExpandedPhotoMode::IPlayer::RotateByXAxis(float amount)
{
    auto xRotation = this->GetInstance()->XRotation;

    xRotation += amount;

    if (xRotation > 1.0f)
        xRotation = 1.0f;

    if (xRotation < -1.0f)
        xRotation = -1.0f;

    this->GetInstance()->XRotation = xRotation;
}

void Nesae::ExpandedPhotoMode::IPlayer::RotateByYAxis(float amount)
{
    auto yRotation = this->GetInstance()->YRotation;

    yRotation += amount;

    if (yRotation > 1.0f)
        yRotation = 1.0f;

    if (yRotation < -1.0f)
        yRotation = -1.0f;

    this->GetInstance()->YRotation = yRotation;
}