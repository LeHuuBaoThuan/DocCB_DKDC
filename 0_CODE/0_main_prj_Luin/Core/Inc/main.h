/* USER CODE BEGIN Header */
/**
  ******************************************************************************
  * @file           : main.h
  * @brief          : Header for main.c file.
  *                   This file contains the common defines of the application.
  ******************************************************************************
  * @attention
  *
  * Copyright (c) 2024 STMicroelectronics.
  * All rights reserved.
  *
  * This software is licensed under terms that can be found in the LICENSE file
  * in the root directory of this software component.
  * If no LICENSE file comes with this software, it is provided AS-IS.
  *
  ******************************************************************************
  */
/* USER CODE END Header */

/* Define to prevent recursive inclusion -------------------------------------*/
#ifndef __MAIN_H
#define __MAIN_H

#ifdef __cplusplus
extern "C" {
#endif

/* Includes ------------------------------------------------------------------*/
#include "stm32f1xx_hal.h"

/* Private includes ----------------------------------------------------------*/
/* USER CODE BEGIN Includes */

/* USER CODE END Includes */

/* Exported types ------------------------------------------------------------*/
/* USER CODE BEGIN ET */

/* USER CODE END ET */

/* Exported constants --------------------------------------------------------*/
/* USER CODE BEGIN EC */

/* USER CODE END EC */

/* Exported macro ------------------------------------------------------------*/
/* USER CODE BEGIN EM */
#define TEST_LED 		(0)
#define TEST_LCD 		(0)
#define TEST_UART 		(1)


/* USER CODE END EM */

/* Exported functions prototypes ---------------------------------------------*/
void Error_Handler(void);

/* USER CODE BEGIN EFP */
/*LED*/
#define L_DBG_Pin GPIO_PIN_13
#define L_DBG_GPIO_Port GPIOC

#define L_ERR_Pin GPIO_PIN_11
#define L_ERR_GPIO_Port GPIOA

#define L_USR_Pin GPIO_PIN_12
#define L_USR_GPIO_Port GPIOA

/*BTN*/
#define BTN1_IT12_Pin GPIO_PIN_12
#define BTN1_IT12_GPIO_Port GPIOB
#define BTN1_IT12_EXTI_IRQn EXTI15_10_IRQn

#define BTN2_IT13_Pin GPIO_PIN_13
#define BTN2_IT13_GPIO_Port GPIOB
#define BTN2_IT13_EXTI_IRQn EXTI15_10_IRQn

#define BTN3_IT14_Pin GPIO_PIN_14
#define BTN3_IT14_GPIO_Port GPIOB
#define BTN3_IT14_EXTI_IRQn EXTI15_10_IRQn

#define BTN4_IT15_Pin GPIO_PIN_15
#define BTN4_IT15_GPIO_Port GPIOB
#define BTN4_IT15_EXTI_IRQn EXTI15_10_IRQn

#define BTN5_IT8_Pin GPIO_PIN_8
#define BTN5_IT8_GPIO_Port GPIOA
#define BTN5_IT8_EXTI_IRQn EXTI9_5_IRQn

/*ENCODER*/
#define ENCB_T2C1_Pin GPIO_PIN_0
#define ENCB_T2C1_GPIO_Port GPIOA
#define ENCA_T2C2_Pin GPIO_PIN_1
#define ENCA_T2C2_GPIO_Port GPIOA

/*UART*/
#define UART2_TX_Pin GPIO_PIN_2
#define UART2_TX_GPIO_Port GPIOA

#define UART2_RX_Pin GPIO_PIN_3
#define UART2_RX_GPIO_Port GPIOA

/*SPI*/
#define SPI1_CS_Pin GPIO_PIN_0
#define SPI1_CS_GPIO_Port GPIOB

/*LCD*/
#define LCD_CTR_Pin GPIO_PIN_7
#define LCD_CTR_GPIO_Port GPIOB
/* USER CODE END EFP */

/* Private defines -----------------------------------------------------------*/
#define L_DBG_Pin GPIO_PIN_13
#define L_DBG_GPIO_Port GPIOC
#define ENCB_T2C1_Pin GPIO_PIN_0
#define ENCB_T2C1_GPIO_Port GPIOA
#define ENCA_T2C2_Pin GPIO_PIN_1
#define ENCA_T2C2_GPIO_Port GPIOA
#define UART2_TX_Pin GPIO_PIN_2
#define UART2_TX_GPIO_Port GPIOA
#define UART2_RX_Pin GPIO_PIN_3
#define UART2_RX_GPIO_Port GPIOA
#define SPI1_CS_Pin GPIO_PIN_0
#define SPI1_CS_GPIO_Port GPIOB
#define BTN1_IT12_Pin GPIO_PIN_12
#define BTN1_IT12_GPIO_Port GPIOB
#define BTN1_IT12_EXTI_IRQn EXTI15_10_IRQn
#define BTN2_IT13_Pin GPIO_PIN_13
#define BTN2_IT13_GPIO_Port GPIOB
#define BTN2_IT13_EXTI_IRQn EXTI15_10_IRQn
#define BTN3_IT14_Pin GPIO_PIN_14
#define BTN3_IT14_GPIO_Port GPIOB
#define BTN3_IT14_EXTI_IRQn EXTI15_10_IRQn
#define BTN4_IT15_Pin GPIO_PIN_15
#define BTN4_IT15_GPIO_Port GPIOB
#define BTN4_IT15_EXTI_IRQn EXTI15_10_IRQn
#define BTN5_IT8_Pin GPIO_PIN_8
#define BTN5_IT8_GPIO_Port GPIOA
#define BTN5_IT8_EXTI_IRQn EXTI9_5_IRQn
#define L_ERR_Pin GPIO_PIN_11
#define L_ERR_GPIO_Port GPIOA
#define L_USR_Pin GPIO_PIN_12
#define L_USR_GPIO_Port GPIOA
#define LCD_CTR_Pin GPIO_PIN_7
#define LCD_CTR_GPIO_Port GPIOB

/* USER CODE BEGIN Private defines */

/* USER CODE END Private defines */

#ifdef __cplusplus
}
#endif

#endif /* __MAIN_H */
