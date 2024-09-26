################################################################################
# Automatically-generated file. Do not edit!
# Toolchain: GNU Tools for STM32 (12.3.rel1)
################################################################################

# Add inputs and outputs from these tool invocations to the build variables 
C_SRCS += \
C:/Users/BaoThuan/OneDrive\ -\ The\ University\ of\ Technology/Desktop/PROJECT/GIT_HUB/0_DoCB_DKDC/0_CODE/1_testADC_DMA/0_app/0_strPrc.c 

OBJS += \
./0_app/0_strPrc.o 

C_DEPS += \
./0_app/0_strPrc.d 


# Each subdirectory must supply rules for building sources it contributes
0_app/0_strPrc.o: C:/Users/BaoThuan/OneDrive\ -\ The\ University\ of\ Technology/Desktop/PROJECT/GIT_HUB/0_DoCB_DKDC/0_CODE/1_testADC_DMA/0_app/0_strPrc.c 0_app/subdir.mk
	arm-none-eabi-gcc -gdwarf-4 "$<" -mcpu=cortex-m3 -std=gnu11 -g3 -DDEBUG -DUSE_HAL_DRIVER -DSTM32F103xB -c -I"C:/Users/BaoThuan/OneDrive - The University of Technology/Desktop/PROJECT/GIT_HUB/0_DoCB_DKDC/0_CODE/1_testADC_DMA/0_app/0_inc" -I../Core/Inc -I../Drivers/STM32F1xx_HAL_Driver/Inc -I../Drivers/STM32F1xx_HAL_Driver/Inc/Legacy -I../Drivers/CMSIS/Device/ST/STM32F1xx/Include -I../Drivers/CMSIS/Include -I../USB_DEVICE/App -I../USB_DEVICE/Target -I../Middlewares/ST/STM32_USB_Device_Library/Core/Inc -I../Middlewares/ST/STM32_USB_Device_Library/Class/CDC/Inc -O0 -ffunction-sections -fdata-sections -Wall -fstack-usage -fcyclomatic-complexity -MMD -MP -MF"$(@:%.o=%.d)" -MT"$@" --specs=nano.specs -mfloat-abi=soft -mthumb -o "$@"

clean: clean-0_app

clean-0_app:
	-$(RM) ./0_app/0_strPrc.cyclo ./0_app/0_strPrc.d ./0_app/0_strPrc.o ./0_app/0_strPrc.su

.PHONY: clean-0_app

